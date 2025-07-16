namespace Project_c_
{
    partial class Search
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
            SignupButton = new Button();
            LoginButton = new Button();
            NumTb = new TextBox();
            label4 = new Label();
            AccNumTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SignupButton
            // 
            SignupButton.BackColor = Color.FromArgb(0, 64, 64);
            SignupButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupButton.ForeColor = Color.White;
            SignupButton.Location = new Point(471, 314);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(111, 43);
            SignupButton.TabIndex = 45;
            SignupButton.Text = "BACK";
            SignupButton.UseVisualStyleBackColor = false;
            SignupButton.Click += SignupButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(0, 64, 64);
            LoginButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(225, 314);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(111, 43);
            LoginButton.TabIndex = 44;
            LoginButton.Text = "GET INFO";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // NumTb
            // 
            NumTb.Location = new Point(247, 255);
            NumTb.Multiline = true;
            NumTb.Name = "NumTb";
            NumTb.Size = new Size(315, 35);
            NumTb.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(247, 219);
            label4.Name = "label4";
            label4.Size = new Size(280, 36);
            label4.TabIndex = 33;
            label4.Text = "REMOVE ACCOUNT";
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(247, 169);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(315, 35);
            AccNumTb.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(247, 134);
            label2.Name = "label2";
            label2.Size = new Size(272, 36);
            label2.TabIndex = 31;
            label2.Text = "SEARCH ACCOUNT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(718, 5);
            label3.Name = "label3";
            label3.Size = new Size(76, 80);
            label3.TabIndex = 20;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(235, 16);
            label1.Name = "label1";
            label1.Size = new Size(376, 62);
            label1.TabIndex = 1;
            label1.Text = "ADMIN PANEL";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 82);
            panel1.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(348, 314);
            button1.Name = "button1";
            button1.Size = new Size(111, 43);
            button1.TabIndex = 46;
            button1.Text = "REMOVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Search
            // 
            ClientSize = new Size(784, 429);
            Controls.Add(button1);
            Controls.Add(SignupButton);
            Controls.Add(LoginButton);
            Controls.Add(NumTb);
            Controls.Add(label4);
            Controls.Add(AccNumTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SignupButton;
        private Button LoginButton;
        private TextBox NumTb;
        private Label label4;
        private TextBox AccNumTb;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Button button1;
        // Renamed the field 'Search' to 'SearchLabel' to avoid conflict with the enclosing type 'Search'
        private Label SearchLabel;
    }
}