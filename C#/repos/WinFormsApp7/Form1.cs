using Microsoft.VisualBasic;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        int[] semester1 = new int[3];
        int[] semester2 = new int[3];
        int x = 0, y = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public int Total(string type)

        {
            int total = 0;
            if (type == "semester1")
            {
                for (int i = 0; i < 3; i++)
                {
                    total += semester1[i];
                }

                return total;
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    total += semester2[i];
                }
                return total;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int total = Total("semester1");
                textBox4.Text = "" + total;

            }
            else if (radioButton2.Checked)
            {
                int total = Total("semester2");
                textBox4.Text = "" + total;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter The name of the Subject : ");
            int mark = Convert.ToInt32(Interaction.InputBox("Enter The Mark of the Subject :"));
            semester2[x] = mark;
            x++;

            listBox1.Items.Add(" " + name + "   " + mark);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter The name of the Subject : ");
            int mark = Convert.ToInt32(Interaction.InputBox("Enter The Mark of the Subject : "));
            semester1[y] = mark;
            y++;

            listBox2.Items.Add(" " + name + "   " + mark);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox1.SelectedText = "";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int total = Total("semester1");
                double per = (total / 3);
                textBox4.Text = "" + per + "%";

            }
            else if (radioButton2.Checked)
            {
                int total = Total("semester2");
                double per = (total / 3);
                textBox4.Text = "" + (per)+"%";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int total = Total("semester1");
                int per = (total / 300) * 100;
                Grade(per);

            }
            else if (radioButton2.Checked)
            {
                int total = Total("semester2");
                int per = (total / 300) * 100;
                Grade(per);

            }
        }
        public void Grade(int per)
        {
            if(per <= 100 && per >= 80)
            {
                textBox4.Text = "A";
            } else if(per < 80 && per >= 70)
            {
                textBox4.Text = "B";
            } else if(per < 70 && per >= 60)
            {
                textBox4.Text = "C";
            } else if(per < 60 && per >= 50)
            {
                textBox4.Text = "D";
            }
            else if (per < 50)
            {
                textBox4.Text = "F";
            }

        }
    }
}
