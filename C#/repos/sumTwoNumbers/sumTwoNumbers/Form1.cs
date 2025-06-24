namespace sumTwoNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int add(Int32 x, Int32 y)
        {
            int sum;
            sum = x + y;
            return sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //double num1 = Convert.ToDouble(textBox1.Text);
            //double num2 = Convert.ToDouble(textBox2.Text);
            //double Result = num1 + num2;
            //textBox3.Text = Convert.ToString(Result + "");

            int a, b, z;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);
            z = add(a, b);
            textBox3.Text = " The Sum is: " + z;

        }
    }
}
