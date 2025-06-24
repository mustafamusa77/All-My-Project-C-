namespace incomeScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double income = 50000;
            double score = 700;
            double userIncome = Convert.ToDouble(textBox1.Text);
            double userScore = Convert.ToDouble(textBox2.Text);
            if(userIncome >= income && userScore >= score)
            {
                MessageBox.Show("your income is Approved");
            }
            else
            {
                MessageBox.Show("your income is Deined");
            }
        }
    }
}
