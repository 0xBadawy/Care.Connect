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
        public MainPage()
        {
            InitializeComponent();
        }

        
        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void patients1_Load(object sender, EventArgs e)
        {

        }

        private int yOffset = 10; // Initial vertical offset for the first button
        private List<Patients> PatientsInPanel = new List<Patients>(); // List to keep track of the buttons in the panel

        private void button1_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();

            int x = 10;
            int y = PatientsInPanel.Count > 0 ? PatientsInPanel.Last().Location.Y + PatientsInPanel.Last().Size.Height + yOffset : yOffset;
            patient.Location = new Point(x, y);

            panel1.Controls.Add(patient);
            PatientsInPanel.Add(patient);
        }
    }
}
