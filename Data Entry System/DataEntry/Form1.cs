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
using System.Data;

namespace DataEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data();
        }




        public void load_data()
        {
            myconnection db = new myconnection();
            db.Open_DB();
            string query = "SELECT * FROM Users";
            MySqlCommand cmd = new MySqlCommand(query, db.mysqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridView1.DataSource = source;
            db.Close_DB();

        }

        private void addData ( )
        { 
            
        //    string ID = textBox_ID.Text;
     //       string Name = textBox_name.Text;
     //       string number = textBox_Num.Text;
     //       string email = textBox_mail.Text;

            myconnection db = new myconnection();
            db.Open_DB();
            string query = "INSERT INTO Users (ID,Name,email,Num) VALUES (@ID,@Name,@Email,@Number)";
            MySqlCommand cmd = new MySqlCommand(query, db.mysqlConnection);
      //      cmd.Parameters.AddWithValue("@ID", ID);
    //        cmd.Parameters.AddWithValue("@Name", Name);
    //        cmd.Parameters.AddWithValue("@Email", email);
    //        cmd.Parameters.AddWithValue("@Number", number);
    //        MessageBox.Show("Data Added Successfully");
            cmd.ExecuteNonQuery();
            db.Close_DB();
            load_data();
        }








    }
}
