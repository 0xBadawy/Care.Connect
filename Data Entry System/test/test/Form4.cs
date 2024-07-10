using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace test
{
    public partial class Form4 : Form
    {
        public string UserID { get; set; } = "";
        public Image _selectedImage;
        public string _selectedImagePath;
        public string _selectedPdfPath;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = UserID;
            show_me();
            show_mc();
            show_ray();
            show_Test();
        }

        public void show_me()
       {
           myconnection.set_myconnection();
            int id = Convert.ToInt32(UserID);

           MySqlCommand cmd = new MySqlCommand();
           cmd.Connection = myconnection.connection;
           cmd.CommandText = "select * from PATIENTINFO where SSN = '"+id+"' ";

           MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

           DataTable table = new DataTable();
           adapter.Fill(table);

           dataGridView1.DataSource = table;
       }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = Convert.ToString(dateTimePicker1.Value);
            string mc = textBox1.Text;
            int ID = Convert.ToInt32(UserID);
            myconnection.set_myconnection();

            myconnection.add_sql("insert into MEDICATIONS(Ussn,CurrentMedication,Date) values('" + ID + "', '" + mc + "', '" + date + "')");

            MessageBox.Show("Done added Medication info","", MessageBoxButtons.OK);

            show_mc();
        }

        public void show_mc()
        {
            myconnection.set_myconnection();
            int id = Convert.ToInt32(UserID);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myconnection.connection;
            cmd.CommandText = "select CurrentMedication from MEDICATIONS where Ussn = '" + id + "' ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView2.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    _selectedImage = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = _selectedImage;
                    _selectedImagePath = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the image: " + ex.Message);
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = Convert.ToString(dateTimePicker2.Value);

            int ID = Convert.ToInt32(UserID);
            myconnection.set_myconnection();

            myconnection.add_sql("insert into RAYS(Ussn,ImagePath,Date) values('" + ID + "', '" +_selectedImagePath + "', '" + date + "')");

            MessageBox.Show("Done added X-ray", "", MessageBoxButtons.OK);
              show_ray();
        }

        public void show_ray()
        {
            myconnection.set_myconnection();
            int id = Convert.ToInt32(UserID);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myconnection.connection;
            cmd.CommandText = "select * from RAYS where Ussn = '" + id + "' ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView3.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";
            openFileDialog.Title = "Select a PDF File";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Save the selected PDF file path into the variable
                    _selectedPdfPath = openFileDialog.FileName;

                    textBox2.Text = Path.GetFileName(_selectedPdfPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the PDF file: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string date = Convert.ToString(dateTimePicker3.Value);

            int ID = Convert.ToInt32(UserID);
            myconnection.set_myconnection();

            myconnection.add_sql("insert into TESTS(Ussn,File,Date) values('" + ID + "', '" +_selectedPdfPath + "', '" + date + "')");

            MessageBox.Show("Done added Test", "", MessageBoxButtons.OK);

            show_Test();
        }

        public void show_Test()
        {
            myconnection.set_myconnection();
            int id = Convert.ToInt32(UserID);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myconnection.connection;
            cmd.CommandText = "select * from TESTS where Ussn = '" + id + "' ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView4.DataSource = table;
        }
    }
}
