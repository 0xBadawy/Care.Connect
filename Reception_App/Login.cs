using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Reception_App
{
    public partial class Login : Form
    {
        IFirebaseClient client = FirebaseConnection.GetFirebaseConnection();
        public Login()
        {
            InitializeComponent();
        }

        public static int HospitalID = 0;
        public static string UserName = "";
        private string Password = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Input_HospitalID.Text == "")
                {
                    MessageBox.Show("Please enter Hospital ID");
                }
                else if (Input_Password.Text == "")
                {
                    MessageBox.Show("Please enter Password");
                }
                else
                {
                    FirebaseResponse loginResponse = client.Get("CareConnect/HDUALogin/" + Input_HospitalID.Text);
                    if (loginResponse.Body == "null")
                        MessageBox.Show("Incorrect Hospital ID");
                    else
                    {
                        JObject loginData = JObject.Parse(loginResponse.Body);
                        Password = loginData["Recep_Password"].ToString();
                        if (Input_Password.Text != Password)
                            MessageBox.Show("Incorrect Password");
                        else
                        {
                            HospitalID = Convert.ToInt32(loginData["ID"]);
                            UserName = loginData["UserName"].ToString();

                            this.Hide();

                            MainPage mainPage = new MainPage();
                            mainPage.Show();
                            //ClassRound o = new ClassRound();
                            //o.HospitalID = Input_HospitalID.Text;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect, Please check your internet connection", "Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
