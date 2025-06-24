namespace Revision
{
    public partial class Form1 : Form
    {
        double calcDiscount = 0;
        double billAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
            comboBox1.Items.Add("Credit card");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter the bill amount.");
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            billAmount = Convert.ToDouble(textBox2.Text);

            if (comboBox1.SelectedItem != null)
            {
                string selectedPayment = comboBox1.SelectedItem.ToString();

                if (selectedPayment == "Cash")
                {
                    textBox3.Text = "8%";
                }
                else if (selectedPayment == "Cheque")
                {
                    textBox3.Text = "7%";
                }
                else if (selectedPayment == "Credit card")
                {
                    textBox3.Text = "0%";
                }

                if (billAmount >= 15000)
                {
                    textBox3.Text = "10%";
                }
            }
            else
            {
                MessageBox.Show("Please select a mode of payment from the options.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter the bill amount.");
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            billAmount = Convert.ToDouble(textBox2.Text);

            if (comboBox1.SelectedItem != null)
            {
                string selectedPayment = comboBox1.SelectedItem.ToString();

                if (selectedPayment == "Cash")
                {
                    calcDiscount = billAmount * 0.08;
                }
                else if (selectedPayment == "Cheque")
                {
                    calcDiscount = billAmount * 0.07;
                }
                else if (selectedPayment == "Credit card")
                {
                    calcDiscount = 0;
                }

                if (billAmount >= 15000)
                {
                    calcDiscount = billAmount * 0.1;
                }

                textBox4.Text = calcDiscount.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Please select a mode of payment from the options.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }
            textBox5.Text = (billAmount - calcDiscount).ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Are you sure you want to stop the process ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
