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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private const string connectionString = "Data Source=MAHiTO\\SQLEXPRESS;Initial Catalog=ATMDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private SqlConnection con;

        private void InitializeSqlConnection()
        {
            con = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewPinLb.Text == "")
            {
                MessageBox.Show("Please enter the new PIN.");
                return;
            }
            else if (ConfirmPinLb.Text == "")
            {
                MessageBox.Show("Please confirm the new PIN.");
                return;
            }
            else if (NewPinLb.Text != ConfirmPinLb.Text)
            {
                MessageBox.Show("New PIN and Confirm PIN do not match.");
                return;
            }
            else
            {
                string accountNumber = Login.accountNum;
                if (con == null)
                {
                    InitializeSqlConnection();
                }
                con!.Open();
                SqlCommand cmd = new("UPDATE AccountTb1 SET Pin = @NewPin WHERE AccNum = @AccountNumber", con);
                cmd.Parameters.AddWithValue("@NewPin", Convert.ToInt32(NewPinLb.Text));
                cmd.Parameters.AddWithValue("@AccountNumber", Login.accountNum);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("PIN Changed Successfully");
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error changing PIN. Please try again.");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }
    }
}
