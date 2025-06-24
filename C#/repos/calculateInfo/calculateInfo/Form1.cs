namespace calculateInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double sum;
            double sub;
            double multi;
            double div;

            if (radioButton1.Checked == true)
            {

                sum = a + b;
                textBox3.Text = $"the sum is {sum}";
            }
            else if (radioButton2.Checked == true)
            {
                sub = a - b;
                textBox3.Text = "the sub is: " + sub;
            }
            else if (radioButton3.Checked == true)
            {
                multi = a * b;
                textBox3.Text = "the multi is: " + multi;
            }
            else if (radioButton4.Checked == true)
            {
                div = a / b;
                textBox3.Text = "the div is: " + div;
            }
            else
            {
                MessageBox.Show("nothing");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
        }
    }
}
