using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class PatientInfo
    {
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

        Dictionary<string, Patient> PatientData = new Dictionary<string, Patient>();

        public void AddPatient(string id, string name, string blood)
        {
            PatientData.Add(id, new Patient(id, name, blood));
        }

        public void LoadData()
        {
            AddPatient("89", "Mohamed Badawy", "A+");
            AddPatient("2", "Ahmed ", "B+");
            AddPatient("3", "Yasser", "O+");
            AddPatient("4", "Tamer", "AB+");

        }

        public string UserNameInfo(string id)
        {

            if (PatientData.ContainsKey(id))
            {
                return PatientData[id].Name;
            }
            return "Not Found";
        }

        public string BloodInfo(string id)
        {
            if (PatientData.ContainsKey(id))
            {
                return PatientData[id].BloodType;
            }
            return "Not Found";
        }

    }
}
