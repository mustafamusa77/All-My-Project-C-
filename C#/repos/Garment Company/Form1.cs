namespace Garment_Company
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double discount;

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
            comboBox1.Items.Add("Credit Card");

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(textBox2.Text);
            double cDiscount;
            if (amount > 15000)
            {
                discount = 10;
                textBox3.Text += " + " + discount.ToString() + "%";

                textBox3.ReadOnly = true;
                cDiscount = amount * 0.10;
                textBox4.Text = cDiscount.ToString();


            }
            else
            {
                if (discount == 8)
                {
                    cDiscount = (amount * 0.08);
                    textBox4.Text = cDiscount.ToString();
                    textBox4.ReadOnly = true;
                }
                else if (discount == 7)
                {
                    cDiscount = (amount * 0.07);
                    textBox4.Text = cDiscount.ToString();
                    textBox4.ReadOnly = true;
                }
                else
                {
                    cDiscount = amount;
                    textBox4.Text = cDiscount.ToString();
                    textBox4.ReadOnly = true;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                discount = 8;
                textBox3.Text = discount.ToString() + "%";
                textBox3.ReadOnly = true;


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                discount = 7;
                textBox3.Text = discount.ToString() + "%";
                textBox3.ReadOnly = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                textBox3.Text = "Null";
                textBox3.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double net = double.Parse(textBox2.Text) - double.Parse(textBox4.Text);
            textBox5.Text = net.ToString();
            textBox5.ReadOnly = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
