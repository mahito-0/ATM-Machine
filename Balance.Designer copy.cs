namespace Project_c_
{
    partial class Balance1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance1));
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            AccNum1 = new Label();
            label5 = new Label();
            BalanceLB = new Label();
            label7 = new Label();
            button7 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Red;
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Name = "label2";
            // 
            // AccNum1
            // 
            resources.ApplyResources(AccNum1, "AccNum1");
            AccNum1.ForeColor = Color.FromArgb(0, 64, 64);
            AccNum1.Name = "AccNum1";
            AccNum1.Click += label4_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Name = "label5";
            // 
            // BalanceLB
            // 
            resources.ApplyResources(BalanceLB, "BalanceLB");
            BalanceLB.ForeColor = Color.FromArgb(0, 64, 64);
            BalanceLB.Name = "BalanceLB";
            BalanceLB.Click += label6_Click;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.FromArgb(0, 64, 64);
            label7.Name = "label7";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 64, 64);
            resources.ApplyResources(button7, "button7");
            button7.ForeColor = Color.White;
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Balance1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button7);
            Controls.Add(BalanceLB);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(AccNum1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance1";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label AccNum1;
        private Label label5;
        private Label BalanceLB;
        private Label label7;
        private Button button7;
    }
}