namespace Project_c_
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            AccNumTb = new TextBox();
            label4 = new Label();
            PinTb = new TextBox();
            LoginBtn = new Button();
            SignupBtn = new Button();
            Adminbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(734, 5);
            label5.Name = "label5";
            label5.Size = new Size(61, 64);
            label5.TabIndex = 21;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(119, 16);
            label1.Name = "label1";
            label1.Size = new Size(570, 50);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(331, 119);
            label2.Name = "label2";
            label2.Size = new Size(252, 50);
            label2.TabIndex = 1;
            label2.Text = "USER LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(316, 187);
            label3.Name = "label3";
            label3.Size = new Size(195, 28);
            label3.TabIndex = 2;
            label3.Text = "Account Number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(316, 218);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(280, 36);
            AccNumTb.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(315, 278);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 5;
            label4.Text = "Pin Number";
            // 
            // PinTb
            // 
            PinTb.BackColor = Color.White;
            PinTb.Location = new Point(315, 309);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(281, 36);
            PinTb.TabIndex = 6;
            PinTb.TextChanged += textBox2_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(0, 64, 64);
            LoginBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(282, 364);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(111, 43);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += Button1_Click;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.FromArgb(0, 64, 64);
            SignupBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = Color.White;
            SignupBtn.Location = new Point(402, 364);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(111, 43);
            SignupBtn.TabIndex = 8;
            SignupBtn.Text = "SIGNUP";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += button2_Click;
            // 
            // Adminbtn
            // 
            Adminbtn.BackColor = Color.FromArgb(0, 64, 64);
            Adminbtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adminbtn.ForeColor = Color.White;
            Adminbtn.Location = new Point(520, 364);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(111, 43);
            Adminbtn.TabIndex = 9;
            Adminbtn.Text = "ADMIN";
            Adminbtn.UseVisualStyleBackColor = false;
            Adminbtn.Click += Adminbtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(Adminbtn);
            Controls.Add(SignupBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PinTb);
            Controls.Add(label4);
            Controls.Add(AccNumTb);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox AccNumTb;
        private Label label4;
        private TextBox PinTb;
        private Button LoginBtn;
        private Button SignupBtn;
        private Label label5;
        private Button Adminbtn;
    }
}