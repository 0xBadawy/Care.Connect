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
    public partial class Patients : UserControl
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient_Detailed_Info form = new Patient_Detailed_Info();
            form.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}
