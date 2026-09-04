using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cafe_Order_Management_System
{
    public partial class frmCustomer : Form
    {
        // Holds the CustomerID of the row currently loaded into the textboxes,
        // 0 means "no row selected" (Insert mode).
        private int currentCustomerId = 0;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        // ---------- Helpers ----------

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                lblStatus.Text = "Customer Name is required.";
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                lblStatus.Text = "Phone Number is required.";
                txtPhone.Focus();
                return false;
            }
            if (!rbMale.Checked && !rbFemale.Checked && !rbOther.Checked)
            {
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                lblStatus.Text = "Please select a Gender.";
                return false;
            }
            if (cboMembership.SelectedIndex == -1)
            {
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                lblStatus.Text = "Please select a Membership Type.";
                cboMembership.Focus();
                return false;
            }
            return true;
        }

        private string GetSelectedGender()
        {
            if (rbMale.Checked) return "Male";
            if (rbFemale.Checked) return "Female";
            return "Others";
        }

        private void SetSelectedGender(string gender)
        {
            rbMale.Checked = gender == "Male";
            rbFemale.Checked = gender == "Female";
            rbOther.Checked = gender != "Male" && gender != "Female";
        }

        private void ClearForm()
        {
            currentCustomerId = 0;
            txtName.Clear();
            txtPhone.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbOther.Checked = false;
            cboMembership.SelectedIndex = -1;
            lblStatus.Text = "";
        }

        private void LoadCustomers()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                if (!DBConnection.TryOpen(con)) return;

                string query = "SELECT CustomerID, CustomerName, PhoneNumber, Gender, MembershipType " +
                               "FROM Customers ORDER BY CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCustomers.DataSource = dt;

                    if (dgvCustomers.Columns.Contains("CustomerID"))
                        dgvCustomers.Columns["CustomerID"].HeaderText = "ID";
                    if (dgvCustomers.Columns.Contains("CustomerName"))
                        dgvCustomers.Columns["CustomerName"].HeaderText = "Customer Name";
                    if (dgvCustomers.Columns.Contains("PhoneNumber"))
                        dgvCustomers.Columns["PhoneNumber"].HeaderText = "Phone Number";
                    if (dgvCustomers.Columns.Contains("MembershipType"))
                        dgvCustomers.Columns["MembershipType"].HeaderText = "Membership";
                }
            }
        }

        // ---------- CRUD ----------

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                if (!DBConnection.TryOpen(con)) return;

                string query = "INSERT INTO Customers (CustomerName, PhoneNumber, Gender, MembershipType) " +
                               "VALUES (@Name, @Phone, @Gender, @Membership)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", GetSelectedGender());
                    cmd.Parameters.AddWithValue("@Membership", cboMembership.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            lblStatus.Text = "Customer added successfully.";
            ClearForm();
            LoadCustomers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                lblStatus.Text = "Enter a Phone Number to search.";
                txtPhone.Focus();
                return;
            }

            using (SqlConnection con = DBConnection.GetConnection())
            {
                if (!DBConnection.TryOpen(con)) return;

                string query = "SELECT CustomerID, CustomerName, PhoneNumber, Gender, MembershipType " +
                               "FROM Customers WHERE PhoneNumber = @Phone";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentCustomerId = Convert.ToInt32(reader["CustomerID"]);
                            txtName.Text = reader["CustomerName"].ToString();
                            txtPhone.Text = reader["PhoneNumber"].ToString();
                            SetSelectedGender(reader["Gender"].ToString());
                            cboMembership.Text = reader["MembershipType"].ToString();

                            lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
                            lblStatus.Text = "Customer found.";
                        }
                        else
                        {
                            lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                            lblStatus.Text = "No customer found with that phone number.";
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentCustomerId == 0)
            {
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                lblStatus.Text = "Search for or select a customer before updating.";
                return;
            }
            if (!ValidateInput()) return;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                if (!DBConnection.TryOpen(con)) return;

                string query = "UPDATE Customers SET CustomerName = @Name, PhoneNumber = @Phone, " +
                               "Gender = @Gender, MembershipType = @Membership WHERE CustomerID = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", GetSelectedGender());
                    cmd.Parameters.AddWithValue("@Membership", cboMembership.Text);
                    cmd.Parameters.AddWithValue("@Id", currentCustomerId);

                    int rows = cmd.ExecuteNonQuery();
                    lblStatus.ForeColor = rows > 0 ? System.Drawing.Color.ForestGreen : System.Drawing.Color.DarkRed;
                    lblStatus.Text = rows > 0 ? "Customer updated successfully." : "Update failed.";
                }
            }

            ClearForm();
            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentCustomerId == 0)
            {
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                lblStatus.Text = "Search for or select a customer before deleting.";
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Delete customer \"" + txtName.Text + "\"?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                if (!DBConnection.TryOpen(con)) return;

                string query = "DELETE FROM Customers WHERE CustomerID = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", currentCustomerId);
                    int rows = cmd.ExecuteNonQuery();
                    lblStatus.ForeColor = rows > 0 ? System.Drawing.Color.ForestGreen : System.Drawing.Color.DarkRed;
                    lblStatus.Text = rows > 0 ? "Customer deleted." : "Delete failed.";
                }
            }

            ClearForm();
            LoadCustomers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
            currentCustomerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
            txtName.Text = row.Cells["CustomerName"].Value.ToString();
            txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
            SetSelectedGender(row.Cells["Gender"].Value.ToString());
            cboMembership.Text = row.Cells["MembershipType"].Value.ToString();
            lblStatus.Text = "";
        }
    }
}
