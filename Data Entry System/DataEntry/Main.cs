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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ShowUser_button_Click(object sender, EventArgs e)
        {
            UserData user = new UserData();
            user.UserID = UserSSN_Number.Text;
            user.UpdateUserIdLabel(); 
            user.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
