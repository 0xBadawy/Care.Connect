using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntry
{
    public partial class UserData : Form
    {

        public string UserID { get; set; } = "";

        public UserData()
        {
            InitializeComponent();
            UpdateUserIdLabel();
        }

        public void UpdateUserIdLabel()
        {
            UserIdLable.Text = UserID;
        }

        private void UserData_Load(object sender, EventArgs e)
        {

        }

        private void UserIdLable_Click(object sender, EventArgs e)
        {

        }

        private void AddMedicament_button_Click(object sender, EventArgs e)
        {
            string ID = UserID;
            string medicament_name = medicamentNameText.Text;
            string Date = DateTime.Now.ToString("yyyy-MM-dd");





        }
    }
}
