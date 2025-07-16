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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=MAHiTO\\SQLEXPRESS;Initial Catalog=ATMDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private SqlConnection con;

        private void InitializeSqlConnection()
        {
            con = new SqlConnection(connectionString);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (con == null)
                {
                    InitializeSqlConnection();
                }
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM AccountTb1 WHERE AccNum = @AccNum", con);
                sda.SelectCommand.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Account Found");
                    UserInfo userInfo = new UserInfo(dt);
                    userInfo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Account Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con == null)
                {
                    InitializeSqlConnection();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM AccountTb1 WHERE AccNum =  '" + NumTb.Text + "'", con);
                cmd.Parameters.AddWithValue("@AccNum", NumTb.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No account found with the given Account Number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
