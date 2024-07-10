using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using CircularProgressBar; // Ensure you have the correct namespace



namespace MainServer
{
    public partial class AddHospital : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Ssanw9rmCXkVYABLZ9pjCX0CECOgIM3bPBCs6zv6",
            BasePath = "https://careconnect-1c393-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        public AddHospital()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            DisplayData();

         }
        private void AddHospital_Load(object sender, EventArgs e)
        {
            LoadInfo();
            CircularProgressBar.CircularProgressBar progressBar = new CircularProgressBar.CircularProgressBar();
            progressBar.Location = new Point(50, 50); // Set desired location
            progressBar.Size = new Size(100, 100); // Set desired size
            this.Controls.Add(progressBar);


        }



        private async void LoadInfo()
        {
            // Call LoadDataFromDatabaseAsync and await its completion
            Dictionary<string, string> data = await LoadDataFromDatabaseAsync();

            // Example: Display loaded data
            foreach (var entry in data)
            {
                MessageBox.Show($"Hospital ID: {entry.Key}, Address: {entry.Value}");
            }
        }



        private async void Btn_Add_Click(object sender, EventArgs e)
        {

        }

        



        private async void DisplayData()
        {
            // Make sure to replace 'client' with your Firebase client instance
            FirebaseResponse response = await client.GetAsync("CareConnect/HospitalLocation");
            var data = response.ResultAs<Dictionary<string, HospitalData>>();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("ID");
            dt.Columns.Add("Address");

            if (data != null)
            {
                foreach (var item in data)
                {
                    dt.Rows.Add(item.Value.Name, item.Value.ID, item.Value.Address);
                }
            }
            dataGridView1.DataSource = dt;
        }

        private async void Btn_Add_Click_1(object sender, EventArgs e)
        {
            var data = new HospitalData
            {
                Name = Hospital_Name.Text,
                ID = Hospital_ID.Text,
                Address = Hospital_Location.Text,
            };

            SetResponse response = await client.SetAsync("/CareConnect/HospitalLocation/Hospital_" + data.ID, data);

            HospitalData result = response.ResultAs<HospitalData>();
            if (result != null)
            {
                DisplayData();
                MessageBox.Show("Hospital added successfully!");
            }
            else
            {
                DisplayData();
                MessageBox.Show("Failed to add hospital.");
            }
        }



        // create a function to load the data form dataBAse from "/CareConnect/HospitalLocation" to a dectionary the key is the ID and the value is the Address 




        public async Task<Dictionary<string, string>> LoadDataFromDatabaseAsync()
        {
            Dictionary<string, string> dataDictionary = new Dictionary<string, string>();

            try
            {
                FirebaseResponse response = await client.GetAsync("CareConnect/HospitalLocation");
                var data = response.ResultAs<Dictionary<string, HospitalData>>();

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        // Add ID and Address to the dictionary
                        dataDictionary.Add(item.Value.ID, item.Value.Address);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataDictionary;
        }

        


    }

}
