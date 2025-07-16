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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=MAHiTO\\SQLEXPRESS;Initial Catalog=ATMDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private SqlConnection con;

        private void InitializeSqlConnection()
        {
            con = new SqlConnection(connectionString);
        }

        public static string? accountNum;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (con == null)
                {
                    InitializeSqlConnection();
                }
                con.Open();
                SqlDataAdapter sda = new("SELECT COUNT(*) FROM AccountTb1 WHERE AccNum = '" + AccNumTb.Text + "' AND Pin = " + PinTb.Text + "", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    accountNum = AccNumTb.Text;
                    MessageBox.Show("Login Successful");
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Account Number or PIN");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            ALogin al = new();
            al.Show();
            this.Hide();
        }
    }
}
