﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_c_
{
    public partial class UserInfo : Form
    {
        public UserInfo(DataTable accountData)
        {
            InitializeComponent();
            MiniStatementataGridView1.DataSource = accountData;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Search search = new Search();          
            search.Show();
            this.Hide();
        }
    }
}
