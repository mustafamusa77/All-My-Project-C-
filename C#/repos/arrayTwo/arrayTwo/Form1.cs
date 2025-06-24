using Microsoft.VisualBasic;

namespace arrayTwo
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
            int[,] a = new int[2, 3];
            for (i =0; i<2; i++)
            {
                for (j = 0; j< 3; j++)
                {
                    string y = Interaction.InputBox("Enter Your Date");
                    a[i, j] = Int32.Parse(y);
                }    
            }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    MessageBox.Show("the elements are:" + a[i, j]);
                    listBox1.Items.Add(a[i, j]);
                }
            }
        }
    }
}
