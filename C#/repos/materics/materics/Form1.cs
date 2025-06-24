using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace materics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            int[,] a = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    string y = Interaction.InputBox("Enter Your Date");
                    a[i, j] = Int32.Parse(y);
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    listBox1.Items.Add(a[i, j]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            int[,] b = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    string y = Interaction.InputBox("Enter Your Date");
                    b[i, j] = Int32.Parse(y);
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    listBox2.Items.Add(b[i, j]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j;
            int[,] a = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    string y = Interaction.InputBox("Enter Your Date");
                    a[i, j] = Int32.Parse(y);
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    listBox1.Items.Add(a[i, j]);
                }
            }
            int[,] b = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    string y = Interaction.InputBox("Enter Your Date");
                    b[i, j] = Int32.Parse(y);
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    listBox2.Items.Add(b[i, j]);
                }
            }
            int[,] sum = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    listBox3.Items.Add(sum[i, j]);
                }
            }
        }
    }
}

