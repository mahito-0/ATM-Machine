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
using Microsoft.VisualBasic;

namespace Project_c_
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=MAHiTO\\SQLEXPRESS;Initial Catalog=ATMDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private SqlConnection con;

        private void InitializeSqlConnection()
        {
            con = new SqlConnection(connectionString);
        }

        public void getBalance()
        {
            if (con == null)
            {
                InitializeSqlConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataAdapter sda = new("SELECT Balance FROM AccountTb1 WHERE AccNum = '" + Login.accountNum + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Balance.Text = dt.Rows[0][0].ToString();
            }
            con.Close();
        }

        private void transactionMethod()
        {
            string transactionType = "Withdraw";
            try
            {
                if (con == null)
                {
                    InitializeSqlConnection();
                }

                con.Open();
                string accountNum = Login.accountNum;
                string query = "INSERT INTO TransactionTb1 values('" + accountNum + "', '" + transactionType + "', '" + WithdrawLb.Text + "','" + DateAndTime.Today.ToString() + "')";
                SqlCommand cmd = new(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the transaction: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(WithdrawLb.Text == "")
            {
                MessageBox.Show("Please enter the amount to withdraw.");
                return;
            }
            else
            {
                if (con == null)
                {
                    InitializeSqlConnection();
                }
                con.Open();
                SqlCommand cmd = new("UPDATE AccountTb1 SET Balance = Balance - @withdrawAmount WHERE AccNum = @accountNum", con);
                cmd.Parameters.AddWithValue("@withdrawAmount", WithdrawLb.Text);
                cmd.Parameters.AddWithValue("@accountNum", Login.accountNum);
                
                int rowsAffected = cmd.ExecuteNonQuery();
                
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Withdrawal Successful");
                    getBalance();
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Withdrawal Failed. Please try again.");
                }
                
                con.Close();
                transactionMethod();
            }
            
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }
}
