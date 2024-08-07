﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Server.PatientInfo;

namespace Server
{
    internal class PatientInfo
    {
        getSQLdata getSQLdata = new getSQLdata();
        Dictionary<string, Patient> PatientData = new Dictionary<string, Patient>();
        Dictionary<string, Dictionary<string, string>> patientData;

        
        public class Patient
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string BloodType { get; set; }

            public Patient(string id, string name, string blood)
            {
                Id = id;
                Name = name;
                BloodType = blood;
            }
        }


        public void AddPatient(string id, string name, string blood)
        {
            PatientData.Add(id, new Patient(id, name, blood));
        }

        public void LoadData()
        {
            patientData = getSQLdata.GetPatientData();
         /*   AddPatient("89", "Mohamed Badawy", "A+");
            AddPatient("2", "Ahmed ", "B+");
            AddPatient("3", "Yasser", "O+");
            AddPatient("4", "Tamer", "AB+");
            AddPatient("2024", "Ahmed mohamed Hassan", "A+");
*/
        }

        public string UserNameInfo(string id)
        {

            if (PatientData.ContainsKey(id))
            {
                return patientData[id]["Name"];

            }
            return "Not Found";
        }

        public string BloodInfo(string id)
        {
           
            if (PatientData.ContainsKey(id))
            {
                return patientData[id]["BloodType"];
            }
            return "Not Found";
        }

        public string PatientPhome(string id)
        {
            if (PatientData.ContainsKey(id))
            {
                return patientData[id]["ParentPhoneNum"];
            }
            return "01095529897";
        }

    }
}
