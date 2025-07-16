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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=MAHiTO\\SQLEXPRESS;Initial Catalog=ATMDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private SqlConnection con;

        private void InitializeSqlConnection()
        {
            con = new SqlConnection(connectionString);
        }

        private int Amount = 0;

        public void getBalance()
        {
            if (con == null)
            {
                InitializeSqlConnection();
            }
            con.Open();
            SqlDataAdapter sda = new("SELECT Balance FROM AccountTb1 WHERE AccNum = '" + Login.accountNum + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Balance.Text = dt.Rows[0][0].ToString();
            }
            int balance = Convert.ToInt32(Balance.Text);
            con.Close();
        }


        private void transactionMethod()
        {
            string transactionType = "Fast Cash";
            try
            {
                if (con == null)
                {
                    InitializeSqlConnection();
                }

                con.Open();
                string accountNum = Login.accountNum;
                string query = "INSERT INTO TransactionTb1 values('" + accountNum + "', '" + transactionType + "', '" + Amount + "','" + DateAndTime.Today.ToString() + "')";
                SqlCommand cmd = new(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the transaction: " + ex.Message);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Balance.Text) < 5000)

            {
                MessageBox.Show("Insufficient Balance");
                return;
            }
            else if (con == null)
            {
                InitializeSqlConnection();
            }
            Amount = 5000;
            con.Open();
            SqlCommand cmd = new("UPDATE AccountTb1 SET Balance = Balance - 5000 WHERE AccNum = @AccountNumber", con);
            cmd.Parameters.AddWithValue("@AccountNumber", Login.accountNum);
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            transactionMethod();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Withdrawal Successful");
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Withdrawal Failed. Please try again.");
            }
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Balance1 b = new Balance1();
            b.Show();
            this.Hide();
        }

        private void Balance_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Balance.Text) < 1500)

            {
                MessageBox.Show("Insufficient Balance");
                return;
            }
            else if (con == null)
            {
                InitializeSqlConnection();
            }
            Amount = 1500;
            con.Open();
            SqlCommand cmd = new("UPDATE AccountTb1 SET Balance = Balance - 1500 WHERE AccNum = @AccountNumber", con);
            cmd.Parameters.AddWithValue("@AccountNumber", Login.accountNum);
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            transactionMethod();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Withdrawal Successful");
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Withdrawal Failed. Please try again.");
            }

        }

        private void five_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Balance.Text) < 500)

            {
                MessageBox.Show("Insufficient Balance");
                return;
            }
            else if (con == null)
            {
                InitializeSqlConnection();
            }
            Amount = 500;
            con.Open();
            SqlCommand cmd = new("UPDATE AccountTb1 SET Balance = Balance - 500 WHERE AccNum = @AccountNumber", con);
            cmd.Parameters.AddWithValue("@AccountNumber", Login.accountNum);
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            transactionMethod();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Withdrawal Successful");
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Withdrawal Failed. Please try again.");
            }
            if (Convert.ToInt32(Balance.Text) < 500)

            {
                                MessageBox.Show("Insufficient Balance");
                return;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Balance.Text) < 1000)

            {
                MessageBox.Show("Insufficient Balance");
                return;
            }
            else if (con == null)
            {
                InitializeSqlConnection();
            }
            Amount = 1000;
            con.Open();
            SqlCommand cmd = new("UPDATE AccountTb1 SET Balance = Balance - 1000 WHERE AccNum = @AccountNumber", con);
            cmd.Parameters.AddWithValue("@AccountNumber", Login.accountNum);
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            transactionMethod();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Withdrawal Successful");
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Withdrawal Failed. Please try again.");
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Balance.Text) < 2000)

            {
                MessageBox.Show("Insufficient Balance");
                return;
            }
            else if (con == null)
            {
                InitializeSqlConnection();
            }
            Amount = 2000;
            con.Open();
            SqlCommand cmd = new("UPDATE AccountTb1 SET Balance = Balance - 2000 WHERE AccNum = @AccountNumber", con);
            cmd.Parameters.AddWithValue("@AccountNumber", Login.accountNum);
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            transactionMethod();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Withdrawal Successful");
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Withdrawal Failed. Please try again.");
            }
        }

        private void ten_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Balance.Text) < 10000)

            {
                MessageBox.Show("Insufficient Balance");
                return;
            }
            else if (con == null)
            {
                InitializeSqlConnection();
            }
            Amount = 10000;
            con.Open();
            SqlCommand cmd = new("UPDATE AccountTb1 SET Balance = Balance - 10000 WHERE AccNum = @AccountNumber", con);
            cmd.Parameters.AddWithValue("@AccountNumber", Login.accountNum);
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            transactionMethod();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Withdrawal Successful");
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Withdrawal Failed. Please try again.");
            }
        }
    }
}
