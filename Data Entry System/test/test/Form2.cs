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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*myconnection.set_myconnection();
            string proname = textBox2.Text;
            string proprice = textBox3.Text;
            myconnection.add_sql("insert into products (productName, productPrice)values('"+proname+"','"+proprice+"')");*/

            //MessageBox.Show("Data is added , done !!");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.UserID = textBox1.Text;
            form4.Show();
        }


       
    }
}
