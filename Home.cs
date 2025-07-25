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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login l = new();
            l.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Balance1 b = new();
            b.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MiniStatement m = new();
            m.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw w = new();
            w.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePin c = new();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FastCash f = new();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deposit d = new();
            d.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
