using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database.Streaming;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json.Linq;

namespace Reception_App
{
    public partial class MainPage : Form
    {
        IFirebaseClient client = FirebaseConnection.GetFirebaseConnection();
        getSQLdata getSQLdata = new getSQLdata();

        List<string> PatientList = new List<string>();
        Dictionary<string, Dictionary<string, string>> patientData;

        public static MainPage instance;
        public MainPage()
        {
            InitializeComponent();
            patientData = getSQLdata.GetPatientData();
            addPatientToHospital("123");
            addPatientToHospital("33222");
            instance = this;
        }

        private void StartListeningForNewRecords()
        {
            try
            {
                FirebaseResponse response = client.Get($"CareConnect/MainServer_Returned_Info/{Login.HospitalID}");
                if( response.Body != "null" && response.Body != null) 
                {
                    Patients patient = new Patients();
                    JObject loginData = JObject.Parse(response.Body);
                    string SSN = loginData["SSN"].ToString();
                    // here we should call the function of MySql to get rest data

                    Add_New_Patient(patient);
                    client.DeleteTaskAsync($"CareConnect/MainServer_Returned_Info/{Login.HospitalID}");
                }
                

            }
            catch (Exception ex)
            {
              //  MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void addPatientToHospital(string patientID)
        {
            PatientList.Add(patientID);
        }
        
        private void MainPage_Load(object sender, EventArgs e)
        {
            loadHospitalPatient();
        }

        private void patients1_Load(object sender, EventArgs e)
        {

        }

        private int yOffset = 10; // Initial vertical offset for the first button
        public List<Patients> PatientsInPanel = new List<Patients>(); // List to keep track of the buttons in the panel

        private void Add_New_Patient(Patients patient)
        {
            PatientsInPanel.Insert(0, patient);
            panel1.Controls.Add(patient);
            UpdateUserControlPositions();
        }

        public void UpdateUserControlPositions()
        {
            int y = 10;
            foreach (var control in PatientsInPanel)
            {
                control.Location = new Point(10, y);
                y += control.Height+10;
            }
        }

        private void loadHospitalPatient()
        {
           foreach (string patientID in PatientList)
            {
                Patients patient = new Patients();

                patient.Lbl_Name.Text = patientData[patientID]["Name"];
       //         patient.Lbl_Age.Text = patientData[patientID]["Age"];
                patient.Lbl_Blood.Text = patientData[patientID]["BloodType"];
                patient.Lbl_Gender.Text = patientData[patientID]["Gender"];
                patient.Lbl_Parent_Phone.Text = patientData[patientID]["ParentPhoneNum"];
                //     patient.Lbl_SSN.Text = patientData["SSN"];

                Add_New_Patient(patient);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartListeningForNewRecords();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
