﻿namespace Project_c_
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(734, 5);
            label3.Name = "label3";
            label3.Size = new Size(61, 64);
            label3.TabIndex = 20;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(280, 13);
            label1.Name = "label1";
            label1.Size = new Size(241, 50);
            label1.TabIndex = 1;
            label1.Text = "ATM HOME";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 64);
            button4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(562, 138);
            button4.Name = "button4";
            button4.Size = new Size(133, 43);
            button4.TabIndex = 11;
            button4.Text = "WITHDRAW";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 64, 64);
            button5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(97, 138);
            button5.Name = "button5";
            button5.Size = new Size(133, 43);
            button5.TabIndex = 12;
            button5.Text = "DEPOSIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(97, 233);
            button1.Name = "button1";
            button1.Size = new Size(133, 43);
            button1.TabIndex = 13;
            button1.Text = "FAST CASH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 64);
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(97, 323);
            button2.Name = "button2";
            button2.Size = new Size(133, 43);
            button2.TabIndex = 14;
            button2.Text = "CHANGE PIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 64);
            button3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(562, 323);
            button3.Name = "button3";
            button3.Size = new Size(133, 43);
            button3.TabIndex = 15;
            button3.Text = "BALANCE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 64, 64);
            button6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(562, 233);
            button6.Name = "button6";
            button6.Size = new Size(133, 43);
            button6.TabIndex = 16;
            button6.Text = "STATEMENT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(238, 85);
            label2.Name = "label2";
            label2.Size = new Size(315, 50);
            label2.TabIndex = 17;
            label2.Text = "SELECT OPTION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 64, 64);
            button7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(333, 390);
            button7.Name = "button7";
            button7.Size = new Size(133, 43);
            button7.TabIndex = 19;
            button7.Text = "LOGOUT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button7;
        private Label label3;
    }
}