namespace Project_c_
{
    partial class MiniStatement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button7 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            MiniStatementataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 64, 64);
            button7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(329, 404);
            button7.Name = "button7";
            button7.Size = new Size(133, 43);
            button7.TabIndex = 22;
            button7.Text = "BACK";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            panel1.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(734, 5);
            label3.Name = "label3";
            label3.Size = new Size(61, 64);
            label3.TabIndex = 21;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(237, 16);
            label1.Name = "label1";
            label1.Size = new Size(345, 50);
            label1.TabIndex = 1;
            label1.Text = "MINISTATEMENT";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MiniStatementataGridView1
            // 
            MiniStatementataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MiniStatementataGridView1.BackgroundColor = Color.Gray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MiniStatementataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MiniStatementataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MiniStatementataGridView1.Location = new Point(0, 125);
            MiniStatementataGridView1.Name = "MiniStatementataGridView1";
            MiniStatementataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            MiniStatementataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MiniStatementataGridView1.Size = new Size(800, 262);
            MiniStatementataGridView1.TabIndex = 23;
            // 
            // MiniStatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(MiniStatementataGridView1);
            Controls.Add(button7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MiniStatement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniStatement";
            Load += MiniStatement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private DataGridView MiniStatementataGridView1;
    }
}