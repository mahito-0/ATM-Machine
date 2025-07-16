namespace Project_c_
{
    partial class ChangePin
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
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            ConfirmPinLb = new TextBox();
            label4 = new Label();
            NewPinLb = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(734, 5);
            label2.Name = "label2";
            label2.Size = new Size(61, 64);
            label2.TabIndex = 22;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(261, 16);
            label1.Name = "label1";
            label1.Size = new Size(254, 50);
            label1.TabIndex = 1;
            label1.Text = "UPDATE PIN";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 64);
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(430, 342);
            button2.Name = "button2";
            button2.Size = new Size(111, 43);
            button2.TabIndex = 17;
            button2.Text = " BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(260, 342);
            button1.Name = "button1";
            button1.Size = new Size(111, 43);
            button1.TabIndex = 16;
            button1.Text = " CHANGE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ConfirmPinLb
            // 
            ConfirmPinLb.BackColor = Color.White;
            ConfirmPinLb.Location = new Point(260, 271);
            ConfirmPinLb.Multiline = true;
            ConfirmPinLb.Name = "ConfirmPinLb";
            ConfirmPinLb.Size = new Size(281, 36);
            ConfirmPinLb.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(260, 240);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 14;
            label4.Text = "CONFIRM PIN";
            // 
            // NewPinLb
            // 
            NewPinLb.Location = new Point(261, 180);
            NewPinLb.Multiline = true;
            NewPinLb.Name = "NewPinLb";
            NewPinLb.Size = new Size(280, 36);
            NewPinLb.TabIndex = 13;
            NewPinLb.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(254, 150);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 11;
            label3.Text = " NEW PIN";
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ConfirmPinLb);
            Controls.Add(label4);
            Controls.Add(NewPinLb);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePin";
            Load += ChangePin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox ConfirmPinLb;
        private Label label4;
        private TextBox NewPinLb;
        private Label label3;
        private Label label2;
    }
}