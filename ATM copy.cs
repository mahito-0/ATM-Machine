namespace Project_c_
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        private void ATM_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int starting = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 5;
            progressBar1.Value = starting;
            Percentage.Text = progressBar1.Value + "%";  
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Percentage_Click(object sender, EventArgs e)
        {

        }
    }
}
