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

        Dictionary<string, string> MainPatientData = new Dictionary<string, string >();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         //   label2.Text = UserID;
            //     show_me();
            //   show_mc();
            // show_ray();
            //show_Test();
            MainPatientData = GetPatientData("22333");
        }

        public void show_me()
        {
            myconnection.set_myconnection();
            int id = Convert.ToInt32(UserID);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myconnection.connection;
            cmd.CommandText = "select * from PATIENTINFO where SSN = '" + id + "' ";

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

            MessageBox.Show("Done added Medication info", "", MessageBoxButtons.OK);

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

        private void LoadData()
        {

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

            myconnection.add_sql("insert into RAYS(Ussn,ImagePath,Date) values('" + ID + "', '" + _selectedImagePath + "', '" + date + "')");

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

            myconnection.add_sql("insert into TESTS(Ussn,File,Date) values('" + ID + "', '" + _selectedPdfPath + "', '" + date + "')");

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



        public void ShowMe()
        {
            try
            {
                myconnection.set_myconnection();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM PATIENTINFO", myconnection.connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        // Perform necessary operations with the adapter
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (myconnection.connection.State == System.Data.ConnectionState.Open)
                {
                    myconnection.connection.Close();
                }
            }
        }

        public Dictionary<string, string> GetPatientData(string UserID)
        {
            var patientData = new Dictionary<string, string>();

            try
            {
                // Set up the database connection
                myconnection.set_myconnection();
                myconnection.connection.Open();

                // Create the SQL command with a parameter to prevent SQL injection
                string query = "SELECT * FROM PATIENTINFO WHERE SSN = @UserID";
                using (MySqlCommand cmd = new MySqlCommand(query, myconnection.connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    // Execute the query and read the data
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the dictionary with data from the reader
                            patientData["SSN"] = reader["SSN"].ToString();
                            patientData["NAME"] = reader["NAME"].ToString();
                            patientData["FINGUREID"] = reader["FINGUREID"].ToString();
                            patientData["GENDER"] = reader["GENDER"].ToString();
                            patientData["CITY"] = reader["CITY"].ToString();
                            patientData["BLOODTYPE"] = reader["BLOODTYPE"].ToString();
                            patientData["MARITALSTATUS"] = reader["MARITALSTATUS"].ToString();
                            patientData["PHONENUM"] = reader["PHONENUM"].ToString();
                            patientData["PARENTPHONENUM"] = reader["PARENTPHONENUM"].ToString();
                            patientData["BIRTHDATE"] = reader["BIRTHDATE"].ToString();
                            patientData["SPECIALHABITS"] = reader["SPECIALHABITS"].ToString();
                            patientData["APPETITE"] = reader["APPETITE"].ToString();
                            patientData["CONCENTRATION"] = reader["CONCENTRATION"].ToString();
                            patientData["LIVING"] = reader["LIVING"].ToString();
                            patientData["PHYACTIVITY"] = reader["PHYACTIVITY"].ToString();
                            patientData["DEFORMITIVES"] = reader["DEFORMITIVES"].ToString();
                            patientData["DIAGOSIS"] = reader["DIAGOSIS"].ToString();
                            patientData["GENERIC"] = reader["GENERIC"].ToString();
                            patientData["MENTALHELTH"] = reader["MENTALHELTH"].ToString();
                            patientData["DISABILITY"] = reader["DISABILITY"].ToString();
                            patientData["PHYCHOLOGICAL"] = reader["PHYCHOLOGICAL"].ToString();
                            patientData["ABUSE"] = reader["ABUSE"].ToString();
                            patientData["CHORONIC"] = reader["CHORONIC"].ToString();
                            patientData["BREATHING"] = reader["BREATHING"].ToString();
                            patientData["MOTOR"] = reader["MOTOR"].ToString();
                            patientData["SENSORY"] = reader["SENSORY"].ToString();
                            patientData["STERILITY"] = reader["STERILITY"].ToString();
                            patientData["BONEFRACTURES"] = reader["BONEFRACTURES"].ToString();
                            patientData["SKINBURNS"] = reader["SKINBURNS"].ToString();
                            patientData["CANCER"] = reader["CANCER"].ToString();
                            patientData["ALCOHOL"] = reader["ALCOHOL"].ToString();
                            patientData["DRUGS"] = reader["DRUGS"].ToString();
                            patientData["ANEMIA"] = reader["ANEMIA"].ToString();
                            patientData["METABOLIC"] = reader["METABOLIC"].ToString();
                            patientData["PREGNANCY"] = reader["PREGNANCY"].ToString();
                            patientData["SURGERY"] = reader["SURGERY"].ToString();
                            patientData["NUMOFSURGERY"] = reader["NUMOFSURGERY"].ToString();
                            patientData["DATEOFLASTSURGERY"] = reader["DATEOFLASTSURGERY"].ToString();
                        }
                        else
                        {
                            Console.WriteLine("No data found for the given UserID.");
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                // Log MySQL specific errors
                Console.WriteLine($"MySQL error occurred: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                // Log general errors
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is closed
                if (myconnection.connection.State == System.Data.ConnectionState.Open)
                {
                    myconnection.connection.Close();
                }
            }

            // Check if the dictionary is empty
            if (patientData.Count == 0)
            {
                Console.WriteLine("The dictionary is empty. No data was retrieved.");
            }

            // Update the label or other UI elements as needed
            UpdateLabel();

            return patientData;
        }




        public void UpdateLabel()
        {
            string allData = "";
            foreach (var item in MainPatientData)
            {
                allData += $"{item.Key}: {item.Value}\n";
            }
            MessageBox.Show(allData);


        }
    }
}
