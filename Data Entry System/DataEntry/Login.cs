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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (Tmam())
            {
                Main main = new Main();
                main.Show();
                this.WindowState = FormWindowState.Minimized;

            }else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private bool Tmam()
        {           
            return true;
        }
    }
}
