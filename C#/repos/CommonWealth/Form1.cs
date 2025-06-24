namespace CommonWealth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int loanAmount) || loanAmount <= 0)
            {
                MessageBox.Show("Please enter a valid loan amount.");
                return;
            }
            double interestRate = 0;

            if (radioButton1.Checked)
                interestRate = 10.0;
            else if (radioButton2.Checked)
                interestRate = 8.5;
            else if (radioButton3.Checked)
                interestRate = 5.0;

            double interestAmount = (loanAmount * interestRate) / 100;
            textBox3.Text = interestAmount.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int loanAmount) || loanAmount <= 0)
            {
                MessageBox.Show("Please enter a valid loan amount.");
                return;
            }

            if (!double.TryParse(textBox3.Text, out double interestAmount))
            {
                MessageBox.Show("Calculate interest first.");
                return;
            }

            double discountRate = (loanAmount <= 10000) ? 0.20 : 0.25;
            double discountAmount = interestAmount * discountRate;
            double netAmount = interestAmount - discountAmount;

            textBox2.Text = discountRate.ToString();
            textBox4.Text = discountAmount.ToString();
            textBox5.Text = netAmount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
