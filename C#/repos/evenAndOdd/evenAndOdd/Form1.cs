namespace evenAndOdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Int32.Parse(textBox1.Text);
            if (a % 2 == 0)
            {
                textBox2.Text = "is even";
            }
            else
            {
                textBox2.Text = "is odd";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
