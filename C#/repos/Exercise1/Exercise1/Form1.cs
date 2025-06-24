namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double var1 = 20.5;
            double var2 = 15.5;
            textBox1.Text = "" + var1;
            textBox2.Text = "" + var2;
            double sum = var1 + var2;
            textBox3.Text = "" + sum;
            double average = sum / 2;
            textBox4.Text = "" + average;
            double division = var1 / var2;
            textBox5.Text = "" + division;
            double round = Math.Round(division, 2);
            textBox5.Text = "" + round;
        }
    }
}
