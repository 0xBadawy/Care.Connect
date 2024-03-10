using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_data_update_App
{
    public partial class HospitalInfo : Form
    {
        public HospitalInfo()
        {
            InitializeComponent();
        }

        private int hospitalId = 0;
        private int hospitalCityID = 0;
        private string hospitalName = "";
        private string hospitalAddress = "";
        private string hospitalLocation = "";
        private string hospitalCity = "";
        private string hospitalPhone = "";


    }
}
