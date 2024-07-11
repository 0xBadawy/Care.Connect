using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reception_App
{
    public partial class MainPage : Form
    {
        IFirebaseClient client = FirebaseConnection.GetFirebaseConnection();
        getSQLdata getSQLdata = new getSQLdata();

        List<string> PatientList = new List<string>();
        Dictionary<string, Dictionary<string, string>> patientData;

        public MainPage()
        {
            InitializeComponent();
            patientData= getSQLdata.GetPatientData();
            addPatientToHospital("123");
            addPatientToHospital("33222");
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
        private List<Patients> PatientsInPanel = new List<Patients>(); // List to keep track of the buttons in the panel

        private void button1_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            PatientsInPanel.Insert(0, patient);
            panel1.Controls.Add(patient);
            UpdateUserControlPositions();
        }


        private void UserControl_DeleteButtonClicked(object sender, Patients userControl)
        {
            // Remove the user control from the list
            PatientsInPanel.Remove(userControl);
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
                


                int x = 10;
                int y = PatientsInPanel.Count > 0 ? PatientsInPanel.Last().Location.Y + PatientsInPanel.Last().Size.Height + yOffset : yOffset;
                patient.Location = new Point(x, y);

                panel1.Controls.Add(patient);
                PatientsInPanel.Add(patient);
            }

        }

    }
}
