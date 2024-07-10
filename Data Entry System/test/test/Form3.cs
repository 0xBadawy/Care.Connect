using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test
{
    public partial class Form3 : Form
    {
       

        public Form3()
        {
            InitializeComponent();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection.set_myconnection();
            string dis = "";
            string phy = "";
            string abuse = "";
            string chronic = "";
            string breathing = "";
            string motor = "";
            string sensory = "";
            string sterility = "";
            string bones = "";
            string skin = "";
            string cancer = "";
            string alcohol ="";
            string drugs="";
            string anemia = "";
            string metabolic = "";
            string pregnancy = "";
            string surgery ="";

            string name = textBox1.Text;
            int ssn = Convert.ToInt32(textBox2.Text);
            int fid = Convert.ToInt32(textBox3.Text);
            string city = textBox4.Text;
            string phonenum = textBox5.Text;
            string parentphone = textBox6.Text;
            string birth = Convert.ToString(dateTimePicker1.Value);
            string gender = comboBox1.Text;
            string blood = comboBox5.Text;
            string marital = comboBox6.Text;

            string habits = textBox7.Text;
            string activity = textBox8.Text;
            string deformitives = textBox9.Text;
            string diagonises = textBox10.Text;
            string generic = textBox11.Text;
            string mental = textBox12.Text;
            int numofs = Convert.ToInt32(textBox13.Text);
            string dateofs = Convert.ToString(dateTimePicker2.Value);
            string appetite = comboBox2.Text;
            string concentration = comboBox3.Text;
            string living = comboBox4.Text;

            
            
            if (checkBox1.Checked == true)
            {
                dis = checkBox1.Text;
            }
            else if (checkBox2.Checked == true)
            {
                dis = checkBox2.Text;
            }

            if (checkBox4.Checked == true)
            {
                phy = checkBox4.Text;
            }
            else if (checkBox3.Checked == true)
            {
                phy = checkBox3.Text;
            }

            if (checkBox6.Checked == true)
            {
                abuse = checkBox6.Text;
            }
            else if (checkBox5.Checked == true)
            {
                abuse = checkBox5.Text;
            }

            if (checkBox8.Checked == true)
            {
                chronic = checkBox8.Text;
            }
            else if (checkBox7.Checked == true)
            {
                chronic = checkBox7.Text;
            }

            if (checkBox10.Checked == true)
            {
                breathing =checkBox10.Text;
            }
            else if (checkBox9.Checked == true)
            {
                breathing = checkBox9.Text;
            }

           
            if (checkBox12.Checked == true)
            {
                motor = checkBox12.Text;
            }
            else if (checkBox11.Checked == true)
            {
                motor = checkBox11.Text;
            }

       
            if (checkBox14.Checked == true)
            {
                sensory = checkBox14.Text;
            }
            else if (checkBox13.Checked == true)
            {
                sensory = checkBox13.Text;
            }

          
            if (checkBox16.Checked == true)
            {
                sterility = checkBox16.Text;
            }
            else if (checkBox15.Checked == true)
            {
                sterility = checkBox15.Text;
            }

        
            if (checkBox18.Checked == true)
            {
                bones = checkBox18.Text;
            }
            else if (checkBox17.Checked == true)
            {
                bones = checkBox17.Text;
            }

           
            if (checkBox20.Checked == true)
            {
                skin = checkBox20.Text;
            }
            else if (checkBox19.Checked == true)
            {
                skin = checkBox19.Text;
            }

           
            if (checkBox22.Checked == true)
            {
                cancer = checkBox22.Text;
            }
            else if (checkBox21.Checked == true)
            {
                cancer = checkBox21.Text;
            }

    
            if (checkBox24.Checked == true)
            {
                alcohol = checkBox24.Text;
            }
            else if (checkBox23.Checked == true)
            {
                alcohol = checkBox23.Text;
            }

            
            if (checkBox26.Checked == true)
            {
                drugs = checkBox26.Text;
            }
            else if (checkBox25.Checked == true)
            {
                drugs = checkBox25.Text;
            }

        
            if (checkBox28.Checked == true)
            {
                anemia = checkBox28.Text;
            }
            else if (checkBox27.Checked == true)
            {
                anemia = checkBox27.Text;
            }

          
            if (checkBox30.Checked == true)
            {
                metabolic = checkBox30.Text;
            }
            else if (checkBox29.Checked == true)
            {
                metabolic = checkBox29.Text;
            }

         
            if (checkBox32.Checked == true)
            {
                pregnancy = checkBox32.Text;
            }
            else if (checkBox31.Checked == true)
            {
                pregnancy = checkBox31.Text;
            }

           
            if (checkBox34.Checked == true)
            {
                surgery = checkBox34.Text;
            }
            else if (checkBox33.Checked == true)
            {
                surgery = checkBox33.Text;
            }

            // insert
            myconnection.add_sql("insert into PATIENTINFO(SSN,NAME,FINGUREID,GENDER,CITY,BLOODTYPE,MARITALSTATUS,PHONENUM,PARENTPHONENUM,BIRTHDATE,SPECIALHABITS,APPETITE,CONCENTRATION,LIVING,PHYACTIVITY,DEFORMITIVES,DIAGOSIS,GENERIC,MENTALHELTH," +
                "DISABILITY,PHYCHOLOGICAL,ABUSE,CHORONIC,BREATHING,MOTOR,SENSORY,STERILITY,BONEFRACTURES,SKINBURNS,CANCER,ALCOHOL,DRUGS,ANEMIA,METABOLIC,PREGNANCY,SURGERY,NUMOFSURGERY,DATEOFLASTSURGERY)" +
                "values('"+ssn+"','"+name+"','"+fid+"','"+gender+"','"+city+"','"+blood+"', '"+marital+"', '"+phonenum+"', '"+parentphone+"','"+birth+"', '"+habits+"', " +
                " '"+appetite+"', '"+concentration+"', '"+living+"', '"+activity+"', '"+deformitives+"', '"+diagonises+"', '"+generic+"', '"+mental+"', '"+dis+"', '"+phy+"'," +
                " '"+abuse+"', '"+chronic+"','"+breathing+"', '"+motor+"', '"+sensory+"', '"+sterility+"','"+bones+"', '"+skin+"', '"+cancer+"'," +
                " '"+alcohol+"', '"+drugs+"', '"+anemia+"', '"+metabolic+"', '"+pregnancy+"', '"+surgery+"', '"+numofs+"','"+dateofs+"')");

            MessageBox.Show("Information added sucessfully", "Patient Info", MessageBoxButtons.OK);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
