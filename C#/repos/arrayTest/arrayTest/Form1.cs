using Microsoft.VisualBasic;

namespace arrayTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int[] numbers = new int[5];
            int sum = 0;
            for (i = 0; i < 5; i++)
            {
                int number = Int32.Parse(Interaction.InputBox("Enter 5 Numbers?"));
                numbers[i] = number;

            }
            for (i = 0; i < 5; i++)
            {
                sum += numbers[i];

            }
            int average = sum / 5;
            String marks = average > 10 ? "You Pass" : "You Fail";

            MessageBox.Show(
                "sum:" + sum.ToString() +
                "\n Average: " + average.ToString() +
                "\n" + marks);
        }
    }
}
