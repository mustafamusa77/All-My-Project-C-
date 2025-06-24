using Microsoft.VisualBasic;

namespace arrayAddition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i, j;
        int[,] a = new int[3,3];
        int[,] b = new int[3,3]; 
        int[,] c = new int[3,3];

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    string y = Interaction.InputBox("Enter Your Date?");
                    a[i, j] = Int32.Parse(y);
                }
            }
            for (i = 0; i < 3; i++)
            {
                richTextBox1.Text += "\n";
                for (j = 0; j < 3; j++)
                {
                    richTextBox1.Text += a[i,j] + "\t";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    string y = Interaction.InputBox("Enter Your Date?");
                    b[i, j] = Int32.Parse(y);
                }
            }
            for (i = 0; i < 3; i++)
            {
                richTextBox2.Text += "\n";
                for (j = 0; j < 3; j++)
                {
                    richTextBox2.Text += b[i,j] + "\t";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    c[i, j] = a[i,j] + b[i,j];
                }
            }
            for (i = 0; i < 3; i++)
            {
                richTextBox3.Text += "\n";
                for (j = 0; j < 3; j++)
                {
                    richTextBox3.Text += c[i,j] + "\t";
                }
            }
        }
    }
}
