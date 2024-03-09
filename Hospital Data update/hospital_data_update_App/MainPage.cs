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


namespace hospital_data_update_App
{
    public partial class MainPage : Form
    {

        private const int CornerRadius = 50;

        public MainPage()
        {
            InitializeComponent();
            RoundPanelBorder(Pan_Main, CornerRadius);
            RoundMainBloodPanel();
            RoundLables();
            updateLabel();
        }

        private int Blood_Type_APlus = 23;
        private int Blood_Type_AMinus = 3;
        private int Blood_Type_BPlus = 32;
        private int Blood_Type_BMinus = 3;
        private int Blood_Type_ABPlus = 34;
        private int Blood_Type_ABMinus = 0;
        private int Blood_Type_OPlus = 0;
        private int Blood_Type_OMinus = 21;



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





        }


        private void updateLabel()
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




    }
}
