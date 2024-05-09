using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;


namespace hospital_data_update_App
{

    public partial class MainPage : Form
    {
        IFirebaseClient client = FirebaseConnection.GetFirebaseConnection();

        private const int CornerRadius = 50;

        private int Blood_Type_APlus;
        private int Blood_Type_AMinus;
        private int Blood_Type_BPlus;
        private int Blood_Type_BMinus;
        private int Blood_Type_ABPlus;
        private int Blood_Type_ABMinus;
        private int Blood_Type_OPlus;
        private int Blood_Type_OMinus;

        private int Room_MaxSize_MED;
        private int Room_MaxSize_IR;
        private int Room_MaxSize_ICU;
        private int Room_MaxSize_EOR;

        private int Room_CurSize_MED;
        private int Room_CurSize_IR;
        private int Room_CurSize_ICU;
        private int Room_CurSize_EOR;

        //private string LastUpdate_Type_APlus;
        //private string LastUpdate_Type_AMinus;
        //private string LastUpdate_Type_BPlus;
        //private string LastUpdate_Type_BMinus;
        //private string LastUpdate_Type_ABPlus;
        //private string LastUpdate_Type_ABMinus;
        //private string LastUpdate_Type_OPlus;
        //private string LastUpdate_Type_OMinus;

        //private string LastUpdate_Room_MED;
        //private string LastUpdate_Room_IR;
        //private string LastUpdate_Room_ICU;
        //private string LastUpdate_Room_EOR;



        public MainPage()
        {
            InitializeComponent();
            RoundPanelBorder(Pan_Main, CornerRadius);
            RoundMainBloodPanel();
            RoundLables();
            InitialValues();
            updateLabelBlood();
            updateLabelRoom();
        }
        private void InitialValues()
        {
            try
            {
                // ------------- connect to firebase and get the data ----------------
                FirebaseResponse DataResponse = client.Get("CareConnect/HospitalData/" + Convert.ToString(Login.HospitalID));
                JObject HospitalData = JObject.Parse(DataResponse.Body);


                // ------------- update varable data ----------------
                Blood_Type_APlus = Convert.ToInt32(HospitalData["APlus"]);
                Blood_Type_AMinus = Convert.ToInt32(HospitalData["AMinus"]);
                Blood_Type_BPlus = Convert.ToInt32(HospitalData["BPlus"]);
                Blood_Type_BMinus = Convert.ToInt32(HospitalData["BMinus"]);
                Blood_Type_ABPlus = Convert.ToInt32(HospitalData["ABPlus"]);
                Blood_Type_ABMinus = Convert.ToInt32(HospitalData["ABMinus"]);
                Blood_Type_OPlus = Convert.ToInt32(HospitalData["OPlus"]);
                Blood_Type_OMinus = Convert.ToInt32(HospitalData["OMinus"]);
                Room_MaxSize_MED = Convert.ToInt32(HospitalData["MaxSize_MED"]);
                Room_MaxSize_IR = Convert.ToInt32(HospitalData["MaxSize_IR"]);
                Room_MaxSize_ICU = Convert.ToInt32(HospitalData["MaxSize_ICU"]);
                Room_MaxSize_EOR = Convert.ToInt32(HospitalData["MaxSize_EOR"]);
                Room_CurSize_MED = Convert.ToInt32(HospitalData["CurSize_MED"]);
                Room_CurSize_IR = Convert.ToInt32(HospitalData["CurSize_IR"]);
                Room_CurSize_ICU = Convert.ToInt32(HospitalData["CurSize_ICU"]);
                Room_CurSize_EOR = Convert.ToInt32(HospitalData["CurSize_EOR"]);



                // ------------- update the last edit date ----------------
                label2.Text = HospitalData["APlus_LastEdit"].ToString();
                label3.Text = HospitalData["AMinus_LastEdit"].ToString();
                label23.Text = HospitalData["BPlus_LastEdit"].ToString();
                label28.Text = HospitalData["BMinus_LastEdit"].ToString();
                label13.Text = HospitalData["ABPlus_LastEdit"].ToString();
                label18.Text = HospitalData["ABMinus_LastEdit"].ToString();
                label33.Text = HospitalData["OPlus_LastEdit"].ToString();
                label38.Text = HospitalData["OMinus_LastEdit"].ToString();
                label14.Text = HospitalData["MED_LastEdit"].ToString();
                label8.Text = HospitalData["IR_LastEdit"].ToString();
                label22.Text = HospitalData["ICU_LastEdit"].ToString();
                label32.Text = HospitalData["EOR_LastEdit"].ToString();


                // ------------- update the hospital name ----------------
                label10.Text = Login.UserName.ToString();
                label11.Text = HospitalData["Name"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect, Please check your internet connection", "Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Pan_Main_Click(object sender, EventArgs e)
        {


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
        void LoginDesignB()
        {
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

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
        public void RoundLabelBorder(Label label, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(label.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(label.Width - cornerRadius, label.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, label.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            label.Region = new Region(path);
        }

        private void RoundMainBloodPanel()
        {
            RoundPanelBorder(panel_type_Ap, 35);
            RoundPanelBorder(panel_type_Bp, 35);
            RoundPanelBorder(panel_type_Am, 35);
            RoundPanelBorder(panel_type_Bm, 35);
            RoundPanelBorder(panel_type_ABp, 35);
            RoundPanelBorder(panel_type_ABm, 35);
            RoundPanelBorder(panel_type_Op, 35);
            RoundPanelBorder(panel_type_Om, 35);

            RoundPanelBorder(panel3, 35);
            RoundPanelBorder(panel6, 35);
            RoundPanelBorder(panel7, 35);
            RoundPanelBorder(panel8, 35);

        }

        private void RoundLables()
        {
            RoundLabelBorder(Lable_inc_Type_ABm, 20);
            RoundLabelBorder(Lable_inc_Type_ABp, 20);
            RoundLabelBorder(Lable_inc_Type_Am, 20);
            RoundLabelBorder(Lable_inc_Type_Ap, 20);
            RoundLabelBorder(Lable_inc_Type_Bm, 20);
            RoundLabelBorder(Lable_inc_Type_Bp, 20);
            RoundLabelBorder(Lable_inc_Type_Om, 20);
            RoundLabelBorder(Lable_inc_Type_Op, 20);

            RoundLabelBorder(Lable_dec_Type_ABm, 20);
            RoundLabelBorder(Lable_dec_Type_ABp, 20);
            RoundLabelBorder(Lable_dec_Type_Am, 20);
            RoundLabelBorder(Lable_dec_Type_Ap, 20);
            RoundLabelBorder(Lable_dec_Type_Bm, 20);
            RoundLabelBorder(Lable_dec_Type_Bp, 20);
            RoundLabelBorder(Lable_dec_Type_Om, 20);
            RoundLabelBorder(Lable_dec_Type_Op, 20);

            RoundLabelBorder(Lable_dec_Room_EOR, 20);
            RoundLabelBorder(Lable_dec_Room_ICU, 20);
            RoundLabelBorder(Lable_dec_Room_IS, 20);
            RoundLabelBorder(Lable_dec_Room_MED, 20);

            RoundLabelBorder(Lable_inc_Room_EOR, 20);
            RoundLabelBorder(Lable_inc_Room_ICU, 20);
            RoundLabelBorder(Lable_inc_Room_IR, 20);
            RoundLabelBorder(Lable_inc_Room_MED, 20);
        }


        private void updateLabelBlood()
        {

            label_NumberOf_Ap.Text = Convert.ToString(Blood_Type_APlus);
            label_NumberOf_Am.Text = Convert.ToString(Blood_Type_AMinus);
            label_NumberOf_Bp.Text = Convert.ToString(Blood_Type_BPlus);
            label_NumberOf_Bm.Text = Convert.ToString(Blood_Type_BMinus);
            label_NumberOf_ABp.Text = Convert.ToString(Blood_Type_ABPlus);
            label_NumberOf_ABm.Text = Convert.ToString(Blood_Type_ABMinus);
            label_NumberOf_Op.Text = Convert.ToString(Blood_Type_OPlus);
            label_NumberOf_Om.Text = Convert.ToString(Blood_Type_OMinus);
        }

        private void updateLabelRoom()
        {
            Label_num_cur_MED.Text = Convert.ToString(Room_CurSize_MED);
            Label_num_cur_IR.Text = Convert.ToString(Room_CurSize_IR);
            Label_num_cur_ICU.Text = Convert.ToString(Room_CurSize_ICU);
            Label_num_cur_EOR.Text = Convert.ToString(Room_CurSize_EOR);

            Label_num_all_MED.Text = "/" + Convert.ToString(Room_MaxSize_MED);
            Label_num_all_IR.Text = "/" + Convert.ToString(Room_MaxSize_IR);
            Label_num_all_ICU.Text = "/" + Convert.ToString(Room_MaxSize_ICU);
            Label_num_all_EOR.Text = "/" + Convert.ToString(Room_MaxSize_EOR);

        }

        private bool CheckIfMin(int Type)
        {
            if (Type <= 0)
            {
                MessageBox.Show("Blood Type is Zero");
                return false;
            }
            return true;

        }

        private bool CheckIfMax(int Type)
        {
            return true;
        }

        private async void UpdateData(string Data, int Amount, string Date, string LableText)
        {
            try
            {
                var UpdateData = new Dictionary<string, object>
                {
                    { Data , Amount }
                };
                await client.UpdateTaskAsync($"CareConnect/HospitalData/{Convert.ToString(Login.HospitalID)}/", UpdateData);

                var UpdateDate = new Dictionary<string, object>
                { 
                    { Date ,  LableText}
                };
                await client.UpdateTaskAsync($"CareConnect/HospitalData/{Convert.ToString(Login.HospitalID)}/", UpdateDate);
            }
            catch (Exception )
            {
                MessageBox.Show("Failed to Update Data, Please check your internet connection", "Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Lable_inc_Type_Ap_Click(object sender, EventArgs e)
        {
            if (CheckIfMax(Blood_Type_APlus))
            {
                Blood_Type_APlus++;
                updateLabelBlood();
                label2.Text = Convert.ToString(DateTime.Now);
                UpdateData("APlus", Blood_Type_APlus , "APlus_LastEdit" , label2.Text);
               
            }
        }


        private void Lable_dec_Type_Ap_Click(object sender, EventArgs e)
        {
            if (CheckIfMin(Blood_Type_APlus))
            {
                Blood_Type_APlus--;
                updateLabelBlood();
                label2.Text = Convert.ToString(DateTime.Now);
                UpdateData("APlus", Blood_Type_APlus, "APlus_LastEdit", label2.Text);
            }
        }

        private void Lable_inc_Type_Bp_Click(object sender, EventArgs e)
        {
            if (CheckIfMax(Blood_Type_BPlus))
            {
                Blood_Type_BPlus++;
                updateLabelBlood();
                label23.Text = Convert.ToString(DateTime.Now);
                UpdateData("BPlus", Blood_Type_BPlus, "BPlus_LastEdit", label23.Text);
            }
        }

        private void Lable_dec_Type_Bp_Click(object sender, EventArgs e)
        {
            if (CheckIfMin(Blood_Type_BPlus))
            {
                Blood_Type_BPlus--;
                updateLabelBlood();
                label23.Text = Convert.ToString(DateTime.Now);
                UpdateData("BPlus", Blood_Type_BPlus, "BPlus_LastEdit", label23.Text);
            }
        }

        private void Lable_inc_Type_ABp_Click(object sender, EventArgs e)
        {
            if (CheckIfMax(Blood_Type_ABPlus))
            {
                Blood_Type_ABPlus++;
                updateLabelBlood();
                label13.Text = Convert.ToString(DateTime.Now);
                UpdateData("ABPlus", Blood_Type_ABPlus, "ABPlus_LastEdit", label13.Text);
            }
        }

        private void Lable_dec_Type_ABp_Click(object sender, EventArgs e)
        {
            if (CheckIfMin(Blood_Type_ABPlus))
            {
                Blood_Type_ABPlus--;
                updateLabelBlood();
                label13.Text = Convert.ToString(DateTime.Now);
                UpdateData("ABPlus", Blood_Type_ABPlus, "ABPlus_LastEdit", label13.Text);
            }
        }
        

        private void Lable_inc_Type_Op_Click(object sender, EventArgs e)
        {
            if (CheckIfMax(Blood_Type_OPlus))
            {
                Blood_Type_OPlus++;
                updateLabelBlood();
                label33.Text = Convert.ToString(DateTime.Now);
                UpdateData("OPlus", Blood_Type_OPlus, "OPlus_LastEdit", label33.Text);
            }
        }

        private void Lable_dec_Type_Op_Click(object sender, EventArgs e)
        {
            if (CheckIfMin(Blood_Type_OPlus))
            {
                Blood_Type_OPlus--;
                updateLabelBlood();
                label33.Text = Convert.ToString(DateTime.Now);
                UpdateData("OPlus", Blood_Type_OPlus, "OPlus_LastEdit", label33.Text);
            }
        }

        private void Lable_inc_Type_Am_Click(object sender, EventArgs e)
        {
            if (CheckIfMax(Blood_Type_AMinus))
            {
                Blood_Type_AMinus++;
                updateLabelBlood();
                label3.Text = Convert.ToString(DateTime.Now);
                UpdateData("AMinus", Blood_Type_AMinus, "AMinus_LastEdit", label3.Text);
            }
        }

        private void Lable_dec_Type_Am_Click(object sender, EventArgs e)
        {
            if (CheckIfMin(Blood_Type_AMinus))
            {
                Blood_Type_AMinus--;
                updateLabelBlood();
                label3.Text = Convert.ToString(DateTime.Now);
                UpdateData("AMinus", Blood_Type_AMinus, "AMinus_LastEdit", label3.Text);
            }
        }

        private void Lable_inc_Type_Bm_Click(object sender, EventArgs e)
        {
            if (CheckIfMax(Blood_Type_BMinus))
            {
                Blood_Type_BMinus++;
                updateLabelBlood();
                label28.Text = Convert.ToString(DateTime.Now);
                UpdateData("BMinus", Blood_Type_BMinus, "BMinus_LastEdit", label28.Text);
            }
        }

        private void Lable_dec_Type_Bm_Click(object sender, EventArgs e)
        {
            if (CheckIfMin(Blood_Type_BMinus))
            {
                Blood_Type_BMinus--;
                updateLabelBlood();
                label28.Text = Convert.ToString(DateTime.Now);
                UpdateData("BMinus", Blood_Type_BMinus, "BMinus_LastEdit", label28.Text);
            }
        }

        private void Lable_inc_Type_ABm_Click(object sender, EventArgs e)
        {
            if (CheckIfMax(Blood_Type_ABMinus))
            {
                Blood_Type_ABMinus++;
                updateLabelBlood();
                label18.Text = Convert.ToString(DateTime.Now);
                UpdateData("ABMinus", Blood_Type_ABMinus, "ABMinus_LastEdit", label18.Text);
            }
        }

        private void Lable_dec_Type_ABm_Click(object sender, EventArgs e)
        {
            if (CheckIfMin(Blood_Type_ABMinus))
            {
                Blood_Type_ABMinus--;
                updateLabelBlood();
                label18.Text = Convert.ToString(DateTime.Now);
                UpdateData("ABMinus", Blood_Type_ABMinus, "ABMinus_LastEdit", label18.Text);
            }
        }

        private void Lable_inc_Type_Om_Click(object sender, EventArgs e)
        {
            if (CheckIfMax(Blood_Type_OMinus))
            {
                Blood_Type_OMinus++;
                updateLabelBlood();
                label38.Text = Convert.ToString(DateTime.Now);
                UpdateData("OMinus", Blood_Type_OMinus, "OMinus_LastEdit", label38.Text);
            }
        }

        private void Lable_dec_Type_Om_Click(object sender, EventArgs e)
        {
            if (CheckIfMin(Blood_Type_OMinus))
            {
                Blood_Type_OMinus--;
                updateLabelBlood();
                label38.Text = Convert.ToString(DateTime.Now);
                UpdateData("OMinus", Blood_Type_OMinus, "OMinus_LastEdit", label38.Text);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool NotOverMax(int curr, int Max)
        {
            if (curr < Max)
                return true;
            return false;
        }
        private void Lable_inc_Room_MED_Click(object sender, EventArgs e)
        {
            if (NotOverMax(Room_CurSize_MED, Room_MaxSize_MED))
            {
                Room_CurSize_MED++;
                updateLabelRoom();
                label14.Text = Convert.ToString(DateTime.Now);
                UpdateData("CurSize_MED", Room_CurSize_MED, "MED_LastEdit", label14.Text);
            }
        }

        private void Lable_inc_Room_IR_Click(object sender, EventArgs e)
        {
            if (NotOverMax(Room_CurSize_IR, Room_MaxSize_IR))
            {
                Room_CurSize_IR++;
                updateLabelRoom();
                label8.Text = Convert.ToString(DateTime.Now);
                UpdateData("CurSize_IR", Room_CurSize_IR, "IR_LastEdit", label8.Text);
            }
        }

        private void Lable_inc_Room_ICU_Click(object sender, EventArgs e)
        {
            if (NotOverMax(Room_CurSize_ICU, Room_MaxSize_ICU))
            {
                Room_CurSize_ICU++;
                updateLabelRoom();
                label22.Text = Convert.ToString(DateTime.Now);
                UpdateData("CurSize_ICU", Room_CurSize_ICU, "ICU_LastEdit", label22.Text);
            }
        }

        private void Lable_inc_Room_EOR_Click(object sender, EventArgs e)
        {
            if (NotOverMax(Room_CurSize_EOR, Room_MaxSize_EOR))
            {
                Room_CurSize_EOR++;
                updateLabelRoom();
                label32.Text = Convert.ToString(DateTime.Now);
                UpdateData("CurSize_EOR", Room_CurSize_EOR, "UpdateDate", label32.Text);
            }
        }

        private void Lable_dec_Room_MED_Click(object sender, EventArgs e)
        {
            if (Room_CurSize_MED > 0)
            {
                Room_CurSize_MED--;
                updateLabelRoom();
                label14.Text = Convert.ToString(DateTime.Now);
                UpdateData("CurSize_MED", Room_CurSize_MED, "MED_LastEdit", label14.Text);
            }
        }

        private void Lable_dec_Room_IS_Click(object sender, EventArgs e)
        {
            if (Room_CurSize_IR > 0)
            {
                Room_CurSize_IR--;
                updateLabelRoom();
                label8.Text = Convert.ToString(DateTime.Now);
                UpdateData("CurSize_IR", Room_CurSize_IR, "IR_LastEdit", label8.Text);
            }
        }

        private void Lable_dec_Room_ICU_Click(object sender, EventArgs e)
        {
            if (Room_CurSize_ICU > 0)
            {
                Room_CurSize_ICU--;
                updateLabelRoom();
                label22.Text = Convert.ToString(DateTime.Now);
                UpdateData("CurSize_ICU", Room_CurSize_ICU, "ICU_LastEdit", label22.Text);
            }
        }

        private void Lable_dec_Room_EOR_Click(object sender, EventArgs e)
        {
            if (Room_CurSize_EOR > 0)
            {
                Room_CurSize_EOR--;
                updateLabelRoom();
                label32.Text = Convert.ToString(DateTime.Now);
                UpdateData("CurSize_EOR", Room_CurSize_EOR, "UpdateDate", label32.Text);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void label_NumberOf_Bp_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_NumberOf_Ap_Click(object sender, EventArgs e)
        {

        }
    }
}
