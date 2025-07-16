using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;




namespace Project_c_
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=MAHiTO\\SQLEXPRESS;Initial Catalog=ATMDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private SqlConnection con;

        private void InitializeSqlConnection()
        {
            con = new SqlConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            int balance = 0;

            if (NameTb.Text == "" || AccNumTb.Text == "" || AddressTb.Text == "" || PinTb.Text == "" || PhoneTb.Text == "" || OccupationTb.Text == "" || DOBDate.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    if (con == null)
                    {
                        InitializeSqlConnection();
                    }

                    con.Open();
                    SqlCommand cmd = new("INSERT INTO AccountTb1 (Name, AccNum, Address, Pin, Phone, Occupation, DOB, Balance) VALUES (@Name, @AccNum, @Address, @Pin, @Phone, @Occupation, @DOB, @Balance)", con);
                    cmd.Parameters.AddWithValue("@Name", NameTb.Text);
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@Address", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Pin", PinTb.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Occupation", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@Dob", DOBDate.Value);
                    cmd.Parameters.AddWithValue("@Balance", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully");

                    Login l = new();
                    l.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
