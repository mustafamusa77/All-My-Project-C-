namespace displayInform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string combination = textBox2.Text;
            string goals = textBox3.Text;

            textBox4.Text = "" + name;
            textBox5.Text = "" + combination;
            textBox6.Text = "" + goals;
        }
    }
}
