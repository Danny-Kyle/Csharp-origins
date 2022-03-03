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

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=create_login;SSLmode=none";
            string query = "INSERT INTO employees(FIRSTNAME,LASTNAME,GENDER,DATEOFBIRTH,PHONENUMBER,EMAILADDRESS,HOMEADDRESS,ACTIVE,SALARY)VALUES('"+this.textBox2.Text+"','"+this.textBox3.Text+"','"+this.textBox4.Text+"','"+this.textBox5.Text+"','"+this.textBox6.Text+"','"+this.textBox7.Text+"','"+this.textBox8.Text+"','"+this.textBox9.Text+"','"+this.textBox10.Text+"')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Saved");
            conn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=create_login;SSLmode=none";
            string query = "UPDATE employees SET FIRSTNAME = '" + this.textBox2.Text + "', LASTNAME = '" + this.textBox3.Text + "', GENDER = '" + this.textBox4.Text + "', DATEOFBIRTH = '" + this.textBox5.Text + "', PHONENUMBER = '" + this.textBox6.Text + "', EMAILADDRESS = '" + this.textBox7.Text + "', HOME = '" + this.textBox8.Text + "',ACTIVE='" + this.textBox9.Text + "', SALARY='" + this.textBox10.Text + "', WHERE ID='" + this.textBox1.Text + "'"; 
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been successfully updated");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=create_login;SSLmode=none";
            string query = "SELECT * FROM employees";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=create_login;SSLmode=none";
            string query = "DELETE FROM employees WHERE ID='" + this.textBox1.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been successfully deleted");
            conn.Close();
        }
    }
}
