namespace groupAss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
            comboBox1.Items.Add("Credit Card");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double billAmount = Convert.ToDouble(textBox2.Text);
            double cashDis = 0.08;
            double chequeDis = 0.07;
            double cardDis = 0;
            double newDis1 = 0.1 + cashDis;
            double newDis2 = 0.1 + chequeDis;
            double newDis3 = 0.1 + cardDis;
            double discount;
            if (comboBox1.Text == "Cash")
            {
                textBox4.Text = "" + cashDis;
                discount = billAmount * cashDis;
                textBox3.Text = "" + discount;

                if (billAmount >= 15000)
                {
                    discount = billAmount * newDis1;
                    textBox3.Text = "" + discount;
                    textBox4.Text = "" + newDis1;
                }
            }
            else if (comboBox1.Text == "Cheque")
            {
                textBox4.Text = "" + chequeDis;
                discount = billAmount * chequeDis;
                textBox3.Text = "" + discount;

                if (billAmount >= 15000)
                {
                    discount = billAmount * newDis2;
                    textBox3.Text = "" + discount;
                    textBox4.Text = "" + newDis2;
                }
            }
            else
            {
                textBox4.Text = "" + cardDis;
                discount = billAmount * cardDis;
                textBox3.Text = "" + discount;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double billAmount = Convert.ToDouble(textBox2.Text);
            double cashDis = 0.08;
            double chequeDis = 0.07;
            double cardDis = 0;
            double newDis1 = 0.1 + cashDis;
            double newDis2 = 0.1 + cardDis;
            double newDis3 = 0.1 + chequeDis;
            double discount;
            double totalAmount;
            if (comboBox1.Text == "Cash")
            {
                textBox4.Text = "" + cashDis;
                discount = billAmount * cashDis;
                textBox3.Text = "" + discount;

                if (billAmount >= 15000)
                {
                    discount = billAmount * newDis1;
                    textBox3.Text = "" + discount;
                    textBox4.Text = "" + newDis1;
                }
                totalAmount = billAmount - discount;
                textBox5.Text = "" + totalAmount;
            }
            else if (comboBox1.Text == "Cheque")
            {
                textBox4.Text = "" + chequeDis;
                discount = billAmount * chequeDis;
                textBox3.Text = "" + discount;

                if (billAmount >= 15000)
                {
                    discount = billAmount * newDis2;
                    textBox3.Text = "" + discount;
                    textBox4.Text = "" + newDis2;
                }
                totalAmount = billAmount - discount;
                textBox5.Text = "" + totalAmount;
            }
            else
            {
                textBox4.Text = "" + cardDis;
                discount = billAmount * cardDis;
                textBox3.Text = "" + discount;
                totalAmount = billAmount - discount;
                textBox5.Text = "" + totalAmount;

            }
        }
    }
}
