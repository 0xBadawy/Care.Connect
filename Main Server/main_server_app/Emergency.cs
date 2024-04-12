using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MainServer
{
    internal class Emergency
    {
        private string ambulance;
        private string finger_print;
        private string location;
        public string Ambulance 
        { get  => ambulance ; set => ambulance = value; }
        public string FingerPrint {  get=> finger_print; set => finger_print = value; }
        public string Location { get=> location; set => location = value; }

        public override string ToString() => $"Ambulance ID: {ambulance}\nFinger Print: {finger_print}\nLocation: {location}";
        
    }
}
