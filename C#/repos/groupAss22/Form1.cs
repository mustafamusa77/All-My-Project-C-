namespace groupAss22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loanAmount = Convert.ToDouble(textBox1.Text);

            double Fdiscount = 0.2;
            double Sdiscount = 0.25;
            double disCountAmount = 0;
            double rate = 0;
            if (radioButton1.Checked)
            {
                rate = 0.1 / 12;
                textBox2.Text = "10%";
            }
            if (radioButton2.Checked)
            {
                rate = 0.85 / 12;
                textBox2.Text = "8.5%";
            }
            if (radioButton3.Checked)
            {
                rate = 0.05 / 12;
                textBox2.Text = "5%";
            }

            if (loanAmount <= 10000)
            {
                disCountAmount = loanAmount * Fdiscount;
                textBox4.Text = "" + disCountAmount;
            }
            else if (loanAmount > 10000)
            {
                disCountAmount = loanAmount * Sdiscount;
                textBox4.Text = "" + disCountAmount;
            }


            int month = Int32.Parse(textBox6.Text);
            double interest = (loanAmount * rate * month);
            textBox3.Text = "" + interest;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double loanAmount = Convert.ToDouble(textBox1.Text);

            double Fdiscount = 0.2;
            double Sdiscount = 0.25;
            double disCountAmount = 0;
            double rate = 0;
            if (radioButton1.Checked)
            {
                rate = 0.1 / 12;
            }
            if (radioButton2.Checked)
            {
                rate = 0.85 / 12;
            }
            if (radioButton3.Checked)
            {
                rate = 0.05 / 12;
            }

            if (loanAmount <= 10000)
            {
                disCountAmount = loanAmount * Fdiscount;
            }
            else if (loanAmount > 10000)
            {
                disCountAmount = loanAmount * Sdiscount;
            }


            int month = Int32.Parse(textBox6.Text);
            double interest = (loanAmount * rate * month);
            double netAmount = (loanAmount + interest) - disCountAmount;
            textBox5.Text = "" + netAmount;
        }
    }
}
