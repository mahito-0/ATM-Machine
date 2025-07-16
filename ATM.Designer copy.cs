namespace Project_c_
{
    partial class ATM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            Percentage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(119, 15);
            label1.Name = "label1";
            label1.Size = new Size(570, 50);
            label1.TabIndex = 0;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(267, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 443);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(799, 23);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Percentage.ForeColor = SystemColors.Control;
            Percentage.Location = new Point(706, 388);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(56, 50);
            Percentage.TabIndex = 3;
            Percentage.Text = "%";
            Percentage.TextAlign = ContentAlignment.TopCenter;
            Percentage.Click += Percentage_Click;
            // 
            // ATM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 468);
            Controls.Add(Percentage);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ATM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ATM_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label Percentage;
    }
}
