using Microsoft.VisualBasic;

namespace loopTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=1;
            while (i < 20)
            {
                listBox1.Items.Add(i);
                i+=1;
            }
           

            
            //do
            //{
               // listBox1.Items.Add("I Love You Mustafa");
             //   i++;

            //} while (i < 11);

            //int i = 0;
            //int[] a = new int[5];
            //for (i=0; i<5; i++)
            //{
            //    String x = Interaction.InputBox("Enter Your Date?");
            //    a[i] = Int32.Parse(x);
            //}
            //for (i =0; i<5; i++)
            //{
            //    MessageBox.Show("The elements are:" + a[i]);
            //}

        }

       
    }
}
