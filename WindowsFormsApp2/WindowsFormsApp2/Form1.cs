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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=create_login;SSLmode=none";
        public void login() 
        {
            string query = "SELECT * FROM login WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            MySqlConnection databaseconnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseconnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseconnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        MessageBox.Show("Welcome to Denizon & Strafeman Capital");
                        Form3 frm3 = new Form3();
                        frm3.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Login Details");
                }
                databaseconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
