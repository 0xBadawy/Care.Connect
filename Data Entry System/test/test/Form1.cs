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
namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text;
            string password = textBox2.Text;

            myconnection.set_myconnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myconnection.connection;
            cmd.CommandText = "select * from Admins where adminName = '" + username + "' and adminPass = '" + password + "' ";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (username == reader.GetString(1) && password == reader.GetString(2))
                {
                    MessageBox.Show("Sucessful Login");
                    Form2 form2 = new Form2();
                    form2.Show();
                    //this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
        }
    }
    
}
