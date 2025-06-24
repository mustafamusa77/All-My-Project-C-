namespace perimterArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length, width;
            length = double.Parse(textBox1.Text);
            width = double.Parse(textBox2.Text);
            double perimeter = 2 * (length + width);
            double area = length * width;
            textBox3.Text = "" + perimeter;
            textBox4.Text = "" + area;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
