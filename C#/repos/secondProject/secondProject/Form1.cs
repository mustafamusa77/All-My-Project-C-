namespace secondProject
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
            double creditScore = 700;
            double userIncome, userScore;

            userIncome = Convert.ToDouble(textBox1.Text);
            userScore = Convert.ToDouble(textBox2.Text);

            if (userIncome >= income && userScore >= creditScore)
            {
                MessageBox.Show("Your loan is Approved");
            }
            else
            {
                MessageBox.Show("Your loan is Denied");
            }
        }

     
    }
}
