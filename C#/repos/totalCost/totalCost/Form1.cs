namespace totalCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double basicCost;
            basicCost = double.Parse(textBox1.Text);
            double saleTax = 0.10;
            double roadTax = 0.02;
            double insurance = 0.15;
            double totalCost = saleTax + roadTax + insurance;
            textBox2.Text = "" + saleTax;
            textBox3.Text = "" + roadTax;
            textBox4.Text = "" + insurance;
            textBox5.Text = "" + totalCost;
        }
    }
}
