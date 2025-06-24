namespace groupAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id, age, production_unit;
            double basic_salary, total_allowances, gross_salary, TA, HRD, UPKEEP;
            string name, marital_status;

            id = Int32.Parse(textBox2.Text);
            age = Int32.Parse(textBox3.Text);
            basic_salary = float.Parse(textBox6.Text);
            name = textBox4.Text;
            marital_status = textBox5.Text;
            production_unit = Int32.Parse(textBox1.Text);

            if (production_unit == 1)
            {
                if (basic_salary >= 5000)
                {
                    TA = (110 / 100) * basic_salary;
                    HRD = 0.2 * basic_salary;
                    UPKEEP = 500;
                    total_allowances = TA + HRD + UPKEEP;
                    gross_salary = total_allowances - basic_salary;

                    textBox13.Text = "" + total_allowances;
                    textBox14.Text = "" + gross_salary;
                }

                else if (basic_salary >= 3000)
                {
                    TA = basic_salary;
                    HRD = 0.15 * basic_salary;
                    UPKEEP = 400;
                    total_allowances = TA + HRD + UPKEEP;
                    gross_salary = total_allowances - basic_salary;

                    textBox13.Text = "" + total_allowances;
                    textBox14.Text = "" + gross_salary;
                }
                else if (basic_salary < 3000)
                {
                    TA = 0.9 * basic_salary;
                    HRD = 0.1 * basic_salary;
                    UPKEEP = 300;
                    total_allowances = TA + HRD + UPKEEP;
                    gross_salary = total_allowances - basic_salary;

                    textBox13.Text = "" + total_allowances;
                    textBox14.Text = "" + gross_salary;
                }

                //textBox7.Text = "" + id;
                textBox8.Text = "" + age;
                textBox9.Text = "" + name;
                textBox10.Text = "" + marital_status;
                textBox11.Text = "Oil Production";
                textBox12.Text = "" + basic_salary;
            }
            else if (production_unit == 2)
            {
                if (basic_salary >= 5000)
                {
                    TA = basic_salary;
                    HRD = 0.1 * basic_salary;
                    UPKEEP = 300;
                    total_allowances = TA + HRD + UPKEEP;
                    gross_salary = total_allowances - basic_salary;

                    textBox13.Text = "" + total_allowances;
                    textBox14.Text = "" + gross_salary;
                }
                else if (basic_salary >= 3000)
                {
                    TA = 0.9 * basic_salary;
                    HRD = 0.1 * basic_salary;
                    UPKEEP = 200;
                    total_allowances = TA + HRD + UPKEEP;
                    gross_salary = total_allowances - basic_salary;

                    textBox13.Text = "" + total_allowances;
                    textBox14.Text = "" + gross_salary;
                }
                else if (basic_salary < 3000)
                {
                    TA = 0.7 * basic_salary;
                    HRD = 0.05 * basic_salary;
                    UPKEEP = 100;
                    total_allowances = TA + HRD + UPKEEP;
                    gross_salary = total_allowances - basic_salary;

                    textBox13.Text = "" + total_allowances;
                    textBox14.Text = "" + gross_salary;
                }

                //textBox7.Text = "" + id;
                textBox8.Text = "" + age;
                textBox9.Text = "" + name;
                textBox10.Text = "" + marital_status;
                textBox11.Text = "Soap Production";
                textBox12.Text = "" + basic_salary;
            }
            else
            {
                MessageBox.Show("Sorry, Invalid Input Enter ( 1 or 2 )");
            }
        }

       
    }
}
