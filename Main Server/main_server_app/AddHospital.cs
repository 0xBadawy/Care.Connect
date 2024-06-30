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

        }
        private async void Btn_Add_Click(object sender, EventArgs e)
        {
           
        }

        // create a void function to disply data in datagridview database 
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
    }

}
