namespace Project_c_
{
    partial class ALogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALogin));
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            SignupBtn = new Button();
            LoginBtn = new Button();
            PinTb = new TextBox();
            label4 = new Label();
            AccNumTb = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
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
            panel1.TabIndex = 9;
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
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.FromArgb(0, 64, 64);
            SignupBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = Color.White;
            SignupBtn.Location = new Point(487, 380);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(111, 43);
            SignupBtn.TabIndex = 17;
            SignupBtn.Text = "SIGNUP";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(0, 64, 64);
            LoginBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(318, 380);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(111, 43);
            LoginBtn.TabIndex = 16;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PinTb
            // 
            PinTb.BackColor = Color.White;
            PinTb.Location = new Point(318, 311);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(281, 36);
            PinTb.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(317, 279);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 14;
            label4.Text = "Pin Number";
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(318, 219);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(280, 36);
            AccNumTb.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(318, 188);
            label3.Name = "label3";
            label3.Size = new Size(195, 28);
            label3.TabIndex = 11;
            label3.Text = "Account Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(313, 120);
            label2.Name = "label2";
            label2.Size = new Size(292, 50);
            label2.TabIndex = 10;
            label2.Text = "ADMIN LOGIN";
            // 
            // ALogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(panel1);
            Controls.Add(SignupBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PinTb);
            Controls.Add(label4);
            Controls.Add(AccNumTb);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ALogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ALogin";
            Load += ALogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label1;
        private Button SignupBtn;
        private Button LoginBtn;
        private TextBox PinTb;
        private Label label4;
        private TextBox AccNumTb;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
    }
}