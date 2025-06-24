using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
namespace MyGUI
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sql = "server=127.0.0.1; password=; user=root; database=mydb";
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO mydetails(name,age,birthday) VALUES(@value1,@value2,@value3)";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                string name = textBox1.Text;
                string age = textBox2.Text;
                int birthday = Convert.ToInt32(dateTimePicker1.Value);

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@value1", name);
                command.Parameters.AddWithValue("@value2", age);
                command.Parameters.AddWithValue("@value3", birthday);

                int row = command.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show("Successfully Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM mydetails WHERE age=@value2";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                string name = textBox1.Text;
                string age = textBox2.Text;
                int birthday = Convert.ToInt32(dateTimePicker1.Value);

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@value1", name);
                command.Parameters.AddWithValue("@value2", age);
                command.Parameters.AddWithValue("@value3", birthday);

                int row = command.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE mydetails SET name=@value1,birthday=@value3 WHERE age=@value2 ";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                string name = textBox1.Text;
                string age = textBox2.Text;
                int birthday = Convert.ToInt32(dateTimePicker1.Value);

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@value1", name);
                command.Parameters.AddWithValue("@value2", age);
                command.Parameters.AddWithValue("@value3", birthday);

                int row = command.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM mydetails";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
