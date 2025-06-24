namespace bankSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            money = Int32.Parse(textBox1.Text);
            int amount = 1500;
            if (money <= amount)
            {
                textBox2.Text = "you have sufficient balance";
            }
            else
            {
                textBox2.Text = "Sorry, you don't have sufficient balance";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int money;
            money = Int32.Parse(textBox1.Text);
            int limit = 1000;
            int amount = 1000;
            int proccessFess = amount - 10;
            if (money <= limit && money <= proccessFess)
            {
                MessageBox.Show("Prccess Succefuly");
            }
            else
            {
                MessageBox.Show("you are out of the limit");
            }

        }
    }
}
