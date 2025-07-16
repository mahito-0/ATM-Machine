namespace Project_c_
{
    partial class Account
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
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            AccNumTb = new TextBox();
            label2 = new Label();
            NameTb = new TextBox();
            label4 = new Label();
            AddressTb = new TextBox();
            label5 = new Label();
            PhoneTb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            PinTb = new TextBox();
            label10 = new Label();
            DOBDate = new DateTimePicker();
            SignupButton = new Button();
            LoginButton = new Button();
            OccupationTb = new TextBox();
            panel1.SuspendLayout();
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
            panel1.TabIndex = 2;
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
            label1.Location = new Point(225, 16);
            label1.Name = "label1";
            label1.Size = new Size(329, 50);
            label1.TabIndex = 1;
            label1.Text = " ACCOUNT INFO";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(22, 115);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(315, 35);
            AccNumTb.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(22, 86);
            label2.Name = "label2";
            label2.Size = new Size(223, 28);
            label2.TabIndex = 5;
            label2.Text = "ACCOUNT NUMBER";
            // 
            // NameTb
            // 
            NameTb.Location = new Point(22, 201);
            NameTb.Multiline = true;
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(315, 35);
            NameTb.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(22, 170);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 8;
            label4.Text = " NAME";
            label4.Click += label4_Click;
            // 
            // AddressTb
            // 
            AddressTb.Location = new Point(22, 282);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(315, 118);
            AddressTb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(22, 251);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 10;
            label5.Text = " ADDRESS";
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(461, 201);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(315, 35);
            PhoneTb.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 64, 64);
            label6.Location = new Point(461, 170);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 12;
            label6.Text = " PHONE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 64, 64);
            label7.Location = new Point(461, 335);
            label7.Name = "label7";
            label7.Size = new Size(66, 28);
            label7.TabIndex = 20;
            label7.Text = " DOB";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 64, 64);
            label8.Location = new Point(461, 251);
            label8.Name = "label8";
            label8.Size = new Size(164, 28);
            label8.TabIndex = 18;
            label8.Text = " OCCUPATION";
            // 
            // PinTb
            // 
            PinTb.Location = new Point(461, 115);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(315, 35);
            PinTb.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 64, 64);
            label10.Location = new Point(461, 86);
            label10.Name = "label10";
            label10.Size = new Size(57, 28);
            label10.TabIndex = 14;
            label10.Text = " PIN";
            // 
            // DOBDate
            // 
            DOBDate.Font = new Font("Segoe UI", 15F);
            DOBDate.Location = new Point(461, 366);
            DOBDate.Name = "DOBDate";
            DOBDate.Size = new Size(315, 34);
            DOBDate.TabIndex = 23;
            // 
            // SignupButton
            // 
            SignupButton.BackColor = Color.FromArgb(0, 64, 64);
            SignupButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupButton.ForeColor = Color.White;
            SignupButton.Location = new Point(426, 413);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(111, 43);
            SignupButton.TabIndex = 28;
            SignupButton.Text = "SIGNUP";
            SignupButton.UseVisualStyleBackColor = false;
            SignupButton.Click += SignupButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(0, 64, 64);
            LoginButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(257, 413);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(111, 43);
            LoginButton.TabIndex = 27;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // OccupationTb
            // 
            OccupationTb.Location = new Point(461, 282);
            OccupationTb.Multiline = true;
            OccupationTb.Name = "OccupationTb";
            OccupationTb.Size = new Size(315, 35);
            OccupationTb.TabIndex = 29;
            OccupationTb.TextChanged += textBox5_TextChanged;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(OccupationTb);
            Controls.Add(SignupButton);
            Controls.Add(LoginButton);
            Controls.Add(DOBDate);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(PinTb);
            Controls.Add(label10);
            Controls.Add(PhoneTb);
            Controls.Add(label6);
            Controls.Add(AddressTb);
            Controls.Add(label5);
            Controls.Add(NameTb);
            Controls.Add(label4);
            Controls.Add(AccNumTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private TextBox AccNumTb;
        private Label label2;
        private TextBox NameTb;
        private Label label4;
        private TextBox AddressTb;
        private Label label5;
        private TextBox PhoneTb;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox PinTb;
        private Label label10;
        private DateTimePicker DOBDate;
        private Button SignupButton;
        private Button LoginButton;
        private TextBox OccupationTb;
    }
}