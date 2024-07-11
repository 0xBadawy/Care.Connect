using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Reception_App
{
    internal class getSQLdata
    {
        /*

        CREATE TABLE `PATIENTINFO` (
          `SSN` int(255) NOT NULL,
          `NAME` varchar(255) NOT NULL,
          `FINGUREID` int(255) NOT NULL,
          `GENDER` varchar(255) NOT NULL,
          `CITY` varchar(255) NOT NULL,
          `BLOODTYPE` varchar(255) NOT NULL,
          `MARITALSTATUS` varchar(255) NOT NULL,
          `PHONENUM` varchar(255) NOT NULL,
          `PARENTPHONENUM` varchar(255) NOT NULL,
          `BIRTHDATE` varchar(255) NOT NULL,
          `SPECIALHABITS` varchar(2000) NOT NULL,
          `APPETITE` varchar(255) NOT NULL,
          `CONCENTRATION` varchar(255) NOT NULL,
          `LIVING` varchar(255) NOT NULL,
          `PHYACTIVITY` varchar(255) NOT NULL,
          `DEFORMITIVES` varchar(255) NOT NULL,
          `DIAGOSIS` varchar(2000) NOT NULL,
          `GENERIC` varchar(255) NOT NULL,
          `MENTALHELTH` varchar(2000) NOT NULL,
          `DISABILITY` varchar(255) NOT NULL,
          `PHYCHOLOGICAL` varchar(255) NOT NULL,
          `ABUSE` varchar(255) NOT NULL,
          `CHORONIC` varchar(255) NOT NULL,
          `BREATHING` varchar(255) NOT NULL,
          `MOTOR` varchar(255) NOT NULL,
          `SENSORY` varchar(255) NOT NULL,
          `STERILITY` varchar(255) NOT NULL,
          `BONEFRACTURES` varchar(255) NOT NULL,
          `SKINBURNS` varchar(255) NOT NULL,
          `CANCER` varchar(255) NOT NULL,
          `ALCOHOL` varchar(255) NOT NULL,
          `DRUGS` varchar(255) NOT NULL,
          `ANEMIA` varchar(255) NOT NULL,
          `METABOLIC` varchar(255) NOT NULL,
          `PREGNANCY` varchar(255) NOT NULL,
          `SURGERY` varchar(255) NOT NULL,
          `NUMOFSURGERY` int(255) NOT NULL,
          `DATEOFLASTSURGERY` varchar(255) NOT NULL
        ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

         */

        public void ShowMe()
        {
            try
            {
                myconnection.set_myconnection();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM PATIENTINFO", myconnection.connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        // Perform necessary operations with the adapter
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (myconnection.connection.State == System.Data.ConnectionState.Open)
                {
                    myconnection.connection.Close();
                }
            }
        }

        public Dictionary<string, Dictionary<string, string>> GetPatientData()
        {
            var patientData = new Dictionary<string, Dictionary<string, string>>();

            try
            {
                myconnection.set_myconnection();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM PATIENTINFO", myconnection.connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var ssn = reader["SSN"].ToString();
                            var patientInfo = new Dictionary<string, string>
                        {
                            { "Name", reader["NAME"].ToString() },
                            { "FingureId", reader["FINGUREID"].ToString() },
                            { "Gender", reader["GENDER"].ToString() },
                            { "City", reader["CITY"].ToString() },
                            { "BloodType", reader["BLOODTYPE"].ToString() },
                            { "MaritalStatus", reader["MARITALSTATUS"].ToString() },
                            { "PhoneNum", reader["PHONENUM"].ToString() },
                            { "ParentPhoneNum", reader["PARENTPHONENUM"].ToString() },
                            { "BirthDate", reader["BIRTHDATE"].ToString() },
                            { "SpecialHabits", reader["SPECIALHABITS"].ToString() },
                            { "Appetite", reader["APPETITE"].ToString() },
                            { "Concentration", reader["CONCENTRATION"].ToString() },
                            { "Living", reader["LIVING"].ToString() },
                            { "PhyActivity", reader["PHYACTIVITY"].ToString() },
                            { "Deformitives", reader["DEFORMITIVES"].ToString() },
                            { "Diagnosis", reader["DIAGOSIS"].ToString() },
                            { "Generic", reader["GENERIC"].ToString() },
                            { "MentalHealth", reader["MENTALHELTH"].ToString() },
                            { "Disability", reader["DISABILITY"].ToString() },
                            { "Phychological", reader["PHYCHOLOGICAL"].ToString() },
                            { "Abuse", reader["ABUSE"].ToString() },
                            { "Choronic", reader["CHORONIC"].ToString() },
                            { "Breathing", reader["BREATHING"].ToString() },
                            { "Motor", reader["MOTOR"].ToString() },
                            { "Sensory", reader["SENSORY"].ToString() },
                            { "Sterility", reader["STERILITY"].ToString() },
                            { "BoneFractures", reader["BONEFRACTURES"].ToString() },
                            { "SkinBurns", reader["SKINBURNS"].ToString() },
                            { "Cancer", reader["CANCER"].ToString() },
                            { "Alcohol", reader["ALCOHOL"].ToString() },
                            { "Drugs", reader["DRUGS"].ToString() },
                            { "Anemia", reader["ANEMIA"].ToString() },
                            { "Metabolic", reader["METABOLIC"].ToString() },
                            { "Pregnancy", reader["PREGNANCY"].ToString() },
                            { "Surgery", reader["SURGERY"].ToString() },
                            { "NumOfSurgery", reader["NUMOFSURGERY"].ToString() },
                            { "DateOfLastSurgery", reader["DATEOFLASTSURGERY"].ToString() }
                        };
                            patientData[ssn] = patientInfo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (myconnection.connection.State == System.Data.ConnectionState.Open)
                {
                    myconnection.connection.Close();
                }
            }

            return patientData;
        }

        /*
        public void printPatientData()
        {
            Dictionary<string, Dictionary<string, string>> patientData= GetPatientData();

            foreach (var patient in patientData)
            {
                string allData = "";
                foreach (var data in patient.Value)
                {
                    allData += $"{data.Key}: {data.Value}\n";
                }
                MessageBox.Show(allData);
            }
        }*/



    }
}
