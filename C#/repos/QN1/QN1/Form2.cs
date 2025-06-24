using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QN1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int checkedCount = 0;
            if (checkBox1.Checked)
                checkedCount++;
            if (checkBox2.Checked)
                checkedCount++;
            if (checkBox3.Checked)
                checkedCount++;
            if (checkBox4.Checked)
                checkedCount++;
            if (checkBox5.Checked)
                checkedCount++;
            if (checkBox6.Checked)
                checkedCount++;

            if(checkedCount > 4)
            {
                MessageBox.Show("You can only select 4 items only");
                return;
            }else if(checkedCount <= 0)
            {
                MessageBox.Show("Please choose one of the check boxes");
            }
            else
            {
                listBox1.Items.Clear();
                if (checkBox1.Checked)
                    listBox1.Items.Add("Ibuprofen (Batch: 02/03/2025 Expire: 02/04/2026)");
                if (checkBox2.Checked)
                    listBox1.Items.Add("Paracetamol (Batch: 23/01/2025 Expire: 22/06/2026)");
                if (checkBox3.Checked)
                    listBox1.Items.Add("Amoxicillin (Batch: 02/01/2025 Expire: 02/04/2026)");
                if (checkBox4.Checked)
                    listBox1.Items.Add("Loratadine (Batch: 02/02/2025 Expire: 02/06/2026)");
                if (checkBox5.Checked)
                    listBox1.Items.Add("Metformin (Batch: 02/01/2025 Expire: 16/04/2026)");
                if (checkBox6.Checked)
                    listBox1.Items.Add("Atorvastatin (Batch: 23/02/2025 Expire: 30/06/2026)");
            }
        }
    }
}