using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace hospital_data_update_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            RoundPanelBorder(panel3, 35);
            RoundLabelBorder(label5, 20);
            RoundLabelBorder(label9, 20);
            RoundPanelBorder(panel1, 35);
            label10.Text = Convert.ToString(DateTime.Now);

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {
            label10.Text = Convert.ToString(DateTime.Now);

        }

        
    }
}