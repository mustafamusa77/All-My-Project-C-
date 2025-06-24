namespace calculatNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double Result = num1 * num2;
            textBox3.Text = Convert.ToString(Result + "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double Result = num1 + num2;
            textBox3.Text = Convert.ToString(Result + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double Result = num1 % num2;
            textBox3.Text = Convert.ToString(Result + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double Result = num1 - num2;
            textBox3.Text = Convert.ToString(Result + "");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double Result = num1 / num2;
            textBox3.Text = Convert.ToString(Result + "");
        }

     
    }
}
