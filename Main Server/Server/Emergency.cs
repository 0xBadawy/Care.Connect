using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Emergency
    {
        private string ambulance;
        private string finger_print;
        private string location;
        public string Ambulance { get; set; }
        public string FingerPrint { get; set; }
        public string Location { get; set; }

        public override string ToString() => $"Ambulance ID: {ambulance}\nFinger Print: {finger_print}\nLocation: {location}";

    }
}
