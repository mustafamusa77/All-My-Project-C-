using Microsoft.VisualBasic;

namespace matrixAddition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,j;
            int[,] a = new int[3,3];
            for(i=0; i< 3; i++)
            {
                for (j=0; j<3; j++)
                {
                    String y= Interaction.InputBox("Enter Your Date?");
                    a[i,j] = Int32.Parse(y);
                }
            }
            string result1 = "\n";
            for (i = 0; i < 3; i++)
            {
                result1 = "\n";
                for (j = 0; j < 3; j++)
                {
                    result1 += a[i,j] + "\t";
                }
                result1 += "\n";
                listBox1.Items.Add(result1);
            }
            int[,] b = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    String y = Interaction.InputBox("Enter Your Date?");
                    b[i,j] = Int32.Parse(y);
                }
            }
            string result2 = "\n";
            for (i = 0; i < 3; i++)
            {
                result2 = "\n";
                for (j = 0; j < 3; j++)
                {
                    result2 += b[i,j] + "\t";
                }
                result2 += "\n";
                listBox2.Items.Add(result2);
            }
            int[,] sum = new int[3,3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum[i,j] = a[i, j] + b[i, j];
                }
            }
            string result = "\n";
            for (i = 0; i < 3; i++)
            {
                result = "\n";
                for (j = 0; j < 3; j++)
                {
                    result += sum[i, j] + "\t";
                }
                result += "\n";
                listBox3.Items.Add(result);
            }
        }
    }
}
