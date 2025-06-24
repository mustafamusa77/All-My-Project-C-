namespace twoFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void one()
        {
            for (int a = 1; a <= 10; a++)
            {
              
            }
        }
        public static void two(Int32 b)
        {
            for (b = 10; b > 10; b++)
            {
                Console.WriteLine(b);
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            one();
        }
    }
}
