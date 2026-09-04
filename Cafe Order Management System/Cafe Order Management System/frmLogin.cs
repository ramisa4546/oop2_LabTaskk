using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cafe_Order_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string password = textBox2.Text;
            string role = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Name and Password.", "Validation");
                return;
            }
            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please select a Role.", "Validation");
                return;
            }

            using (SqlConnection con = DBConnection.GetConnection())
            {
                if (!DBConnection.TryOpen(con)) return;

                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName " +
                               "AND Password = @Password AND Role = @Role";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role.Trim());

                    int matches = (int)cmd.ExecuteScalar();
                    if (matches > 0)
                    {
                        this.Hide();
                        frmCustomer customerForm = new frmCustomer();
                        customerForm.FormClosed += (s, args) => this.Close();
                        customerForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid name, password, or role.", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
