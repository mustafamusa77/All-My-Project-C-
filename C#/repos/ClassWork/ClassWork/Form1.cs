using Microsoft.VisualBasic;

namespace ClassWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int lowest(int[] arr)
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < temp)
                {
                    temp = arr[i];
                }
            }
            return temp;
        }

        public static int highest(int[] arr)
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > temp)
                {
                    temp = arr[i];
                }
            }
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[20];

            for (int i = 0; i < 20; i++)
            {
                arr[i] = Int32.Parse(Interaction.InputBox("Enter number " + (i + 1).ToString() + ": "));
            }

            for (int i = 0; i < arr.Length; i++)
            {
                listBox1.Items.Add(arr[i]);
            }

            label2.Text = lowest(arr).ToString();
            label1.Text = highest(arr).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
