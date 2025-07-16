using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using static Azure.Core.HttpHeader;

namespace Project_c_
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=MAHiTO\\SQLEXPRESS;Initial Catalog=ATMDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private SqlConnection con;

        private void InitializeSqlConnection()
        {
            con = new SqlConnection(connectionString);
        }

        private void transactionMethod()
        {
            string transactionType = "Deposit";
            try
            {
                if (con == null)
                {
                    InitializeSqlConnection();
                }

                con.Open();
                string accountNum = Login.accountNum;
                string query = "INSERT INTO TransactionTb1 values('" + accountNum + "', '" + transactionType + "', '" + DepositTxt.Text + "','" + DateAndTime.Today.ToString() + "')";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (DepositTxt.Text == "")
            {
                MessageBox.Show("Please enter the amount to deposit.");
                return;
            }
            else
            {
               // string accountNumber = Login.accountNum;
                if (con == null)
                {
                    InitializeSqlConnection();
                }
                con.Open();
                SqlCommand cmd = new("UPDATE AccountTb1 SET Balance = Balance + @DepositAmount WHERE AccNum = @AccountNumber", con);
                cmd.Parameters.AddWithValue("@DepositAmount", Convert.ToInt32(DepositTxt.Text));
                cmd.Parameters.AddWithValue("@AccountNumber", Login.accountNum);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deposit Successful");
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Deposit Failed. Please try again.");
                }

                con.Close();
                transactionMethod();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
