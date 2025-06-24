namespace testNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(textBox1.Text);
            if (num > 0)
            {
                textBox2.Text = ("Positive");
            }
            else if (num == 0)
            {
                textBox2.Text = "Nutral";
            }
            else
            {
                textBox2.Text = ("Negative");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
