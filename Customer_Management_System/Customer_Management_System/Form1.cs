using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Customer_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string gender = "";
            string category = "";

            if (rbMale.Checked) gender = "Male";
            else if (rbFemale.Checked) gender = "Female";
            else if (rbOther.Checked) gender = "Other";

            if (chkRegular.Checked) category = "Regular";
            else if (chkPremium.Checked) category = "Premium";
            else if (chkDiscount.Checked) category = "Discount";
            else if (chkNewCustomer.Checked) category = "New Customer";

            if (txtName.Text == "" || txtPassword.Text == "" || gender == "" || category == "")
            {
                MessageBox.Show("Fill all fields.");
                return;
            }
            


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True");

            con.Open();
            string query = "INSERT INTO Register1 ([Name], [Password], [Gender], [Category]) " +
                         
                         "VALUES ('" + txtName.Text + "', '" + txtPassword.Text + "', '" +
                   gender + "', '" + category + "')";



            SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE CustomerName=@name", con);
            check.Parameters.AddWithValue("@name", txtName.Text);

            if ((int)check.ExecuteScalar() > 0)
            {
                MessageBox.Show("Customer already exists.");
                con.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Customers VALUES(@name,@pass,@gender,@category)", con);

            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@category", category);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Inserted Successfully");
        }
        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=formsubmission;Integrated Security=True");

            con.Open();

            string query = "DELETE FROM Register1 WHERE [User Name] = '" + txtName.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            int result = cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(result + " record deleted!");
        }
    


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
