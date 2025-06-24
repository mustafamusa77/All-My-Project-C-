using System.Numerics;

namespace fristProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int studentNum = Int32.Parse(label7.Text);

            if (studentNum >= 5)
            {
                MessageBox.Show("You have finied of 5 students");
            }
            label7.Text = Convert.ToString(studentNum + 1);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mark1 = Convert.ToDouble(textBox1.Text);
            double mark2 = Convert.ToDouble(textBox2.Text);
            double mark3 = Convert.ToDouble(textBox3.Text);
            if (mark1 <= 100 && mark2 <= 100 && mark3 <= 100)
            {
                double total = mark1 + mark2 + mark3;

                textBox4.Text = Convert.ToString(total);
            }
            else
            {
                MessageBox.Show("Sorry, Enter Mark Between 1 and 100");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double mark1 = Convert.ToDouble(textBox1.Text);
            double mark2 = Convert.ToDouble(textBox2.Text);
            double mark3 = Convert.ToDouble(textBox3.Text);
            if (mark1 <= 100 && mark2 <= 100 && mark3 <= 100)
            {
                double total = mark1 + mark2 + mark3;
                double per = (total / 300) * 100;
                textBox4.Text = Convert.ToString(per + "%");
            }
            else
            {
                MessageBox.Show("Sorry, Enter Mark Between 1 and 100");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double mark1 = Convert.ToDouble(textBox1.Text);
            double mark2 = Convert.ToDouble(textBox2.Text);
            double mark3 = Convert.ToDouble(textBox3.Text);
            if (mark1 <= 100 && mark2 <= 100 && mark3 <= 100)
            {
                double total = mark1 + mark2 + mark3;
                double per = (total / 300) * 100;

                if (per >= 80)
                {
                    textBox4.Text = "A";
                }
                else if (per >= 65)
                {
                    textBox4.Text = "B";
                }
                else if (per >= 50)
                {
                    textBox4.Text = "C";
                }
                else
                {
                    textBox4.Text = "F";
                }
            }
            else
            {
                MessageBox.Show("Sorry, Enter Mark Between 1 and 100");
            }

        }

       
    }
}
