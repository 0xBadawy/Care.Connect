using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppAPI_TEST
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            MyFunction();
        }
        public void MyFunction()
        {

            Dictionary<string, Tuple<double, double>> Data = new Dictionary<string, Tuple<double, double>>();

            Data["Hospital1"] = Tuple.Create(25.7310834, 32.7027886);
            Data["Hospital2"] = Tuple.Create(26.0550735, 32.7796929);
            Data["Hospital3"] = Tuple.Create(26.1691376, 32.6348107);
            Data["Hospital4"] = Tuple.Create(26.1472582, 32.5270074);
            Data["Hospital5"] = Tuple.Create(25.9876543, 32.8765432);
            Data["Hospital6"] = Tuple.Create(26.1234567, 32.7654321);
            Data["Hospital7"] = Tuple.Create(25.5432109, 32.6543210);
            Data["Hospital8"] = Tuple.Create(26.6789123, 32.5432109);
            Data["Hospital9"] = Tuple.Create(25.4321098, 32.4321098);
            Data["Hospital10"] = Tuple.Create(26.3210987, 32.3210987);
            Data["Hospital11"] = Tuple.Create(25.8765432, 32.9876543);
            Data["Hospital12"] = Tuple.Create(26.7654321, 32.8765432);
            Data["Hospital13"] = Tuple.Create(25.6543210, 32.7654321);
            Data["Hospital14"] = Tuple.Create(26.5432109, 32.6543210);
            Data["Hospital15"] = Tuple.Create(25.4321098, 32.5432109);
            Data["Hospital16"] = Tuple.Create(26.3210987, 32.4321098);
            Data["Hospital17"] = Tuple.Create(25.2109876, 32.3210987);
            Data["Hospital18"] = Tuple.Create(26.1098765, 32.2109876);
            Data["Hospital19"] = Tuple.Create(25.0987654, 32.1098765);
            Data["Hospital20"] = Tuple.Create(26.9876543, 32.0987654);
            Data["Hospital21"] = Tuple.Create(25.8765432, 32.9876543);
            Data["Hospital22"] = Tuple.Create(26.7654321, 32.8765432);
            Data["Hospital23"] = Tuple.Create(25.6543210, 32.7654321);
            Data["Hospital24"] = Tuple.Create(26.5432109, 32.6543210);
            Data["Hospital25"] = Tuple.Create(25.4321098, 32.5432109);
            Data["Hospital26"] = Tuple.Create(26.3210987, 32.4321098);
            Data["Hospital27"] = Tuple.Create(25.2109876, 32.3210987);
            Data["Hospital28"] = Tuple.Create(26.1098765, 32.2109876);
            Data["Hospital29"] = Tuple.Create(25.0987654, 32.1098765);
            Data["Hospital30"] = Tuple.Create(26.9876543, 32.0987654);
            Data["Hospital31"] = Tuple.Create(25.8765432, 32.9876543);
            Data["Hospital32"] = Tuple.Create(26.7654321, 32.8765432);
            Data["Hospital33"] = Tuple.Create(25.6543210, 32.7654321);
            Data["Hospital34"] = Tuple.Create(26.5432109, 32.6543210);
            Data["Hospital35"] = Tuple.Create(25.4321098, 32.5432109);
            Data["Hospital36"] = Tuple.Create(26.3210987, 32.4321098);
            Data["Hospital37"] = Tuple.Create(25.2109876, 32.3210987);
            Data["Hospital38"] = Tuple.Create(26.1098765, 32.2109876);
            Data["Hospital39"] = Tuple.Create(25.0987654, 32.1098765);
            Data["Hospital40"] = Tuple.Create(26.9876543, 32.0987654);
            Data["Hospital41"] = Tuple.Create(25.8765432, 32.9876543);
            Data["Hospital42"] = Tuple.Create(26.7654321, 32.8765432);
            Data["Hospital43"] = Tuple.Create(25.6543210, 32.7654321);
            Data["Hospital44"] = Tuple.Create(26.5432109, 32.6543210);
            Data["Hospital45"] = Tuple.Create(25.4321098, 32.5432109);
            Data["Hospital46"] = Tuple.Create(26.3210987, 32.4321098);
            Data["Hospital47"] = Tuple.Create(25.2109876, 32.3210987);
            Data["Hospital48"] = Tuple.Create(26.1098765, 32.2109876);
            Data["Hospital49"] = Tuple.Create(25.0987654, 32.1098765);
            Data["Hospital50"] = Tuple.Create(26.9876543, 32.0987654);


            Tuple<double, double> MyLocation = Tuple.Create(25.7310834, 32.7027886);

            Dictionary<string, double> Distance = CalculateDistance(Data, MyLocation);

            string result = "";
            foreach (var item in Distance)
            {
                result += (item.Key + " : " + item.Value + "" + "\n");
            }

            richTextBox1.Text = result;

        }

        public Dictionary<string, double> CalculateDistance(Dictionary<string, Tuple<double, double>> data, Tuple<double, double> MyLocation)
        {

            Dictionary<string, double> diatace = new Dictionary<string, double>();
            foreach (var item in data)
            {
                double x = Math.Pow((item.Value.Item1 - MyLocation.Item1), 2);
                double y = Math.Pow((item.Value.Item2 - MyLocation.Item2), 2);
                double distance = Math.Sqrt(x + y);
                diatace[item.Key] = (float)distance;
            }

            Dictionary<string, double> Distance = diatace;
            Distance = Distance.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);


            return Distance;
        }






    }
}
