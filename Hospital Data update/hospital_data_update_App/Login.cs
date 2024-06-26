﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace hospital_data_update_App
{
    public partial class Login : Form
    {
        IFirebaseClient client = FirebaseConnection.GetFirebaseConnection();
        private const int CornerRadius = 50;
        
        public Login()
        {
            InitializeComponent();
            LoginDesignB();
        }


        public static int HospitalID = 0;
        public static string UserName = "";
        private string Password = "";


        void LoginDesignB()
        {
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            RoundPictureBox(pictureBox1);
            Region roundedRegion = new Region(CreateRoundRectangle(btn_Login.ClientRectangle, 20));
            btn_Login.Region = roundedRegion;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                path.CloseFigure();

                Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    graphics.FillPath(brush, path);
                }

                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    graphics.DrawPath(pen, path);
                }
            }

            base.OnPaint(e);
        }


        private void RoundPictureBox(PictureBox pictureBox)
        {
            int borderRadius = 52;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(pictureBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(pictureBox.Width - borderRadius, pictureBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, pictureBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            pictureBox.Region = new Region(path);
        }

        private GraphicsPath CreateRoundRectangle(Rectangle rectangle, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectangle.Location, size);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                        Password = loginData["Password"].ToString();
                        if (Input_Password.Text != Password)
                            MessageBox.Show("Incorrect Password");
                        else
                        {
                            HospitalID = Convert.ToInt32(loginData["ID"]);
                            UserName = loginData["UserName"].ToString();

                            this.Hide();
                            MainPage mainPage = new MainPage();
                            mainPage.Show();
                            ClassRound o = new ClassRound();
                            o.HospitalID = Input_HospitalID.Text;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect, Please check your internet connection", "Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        public void RoundPanelBorder(Panel panel, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Input_Password_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("Please enter Password");
        }

    }
}
