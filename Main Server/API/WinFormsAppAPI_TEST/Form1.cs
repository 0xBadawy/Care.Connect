using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO;


namespace WinFormsAppAPI_TEST
{
    public partial class Form1 : Form
    {

        string url = "";
        Rootobject rootobject;
        private const string ApiKey = "PITmMtX8zjb9IeC4sjnmTiWT8zCCyp3uSvJ4QCjyENxapT6vaPGtmrZOcbHuLFLP";
        private const string BaseUrl = "https://api.distancematrix.ai/maps/api/distancematrix/json";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float len = APIDataDistance(textBox_From.Text, textBox_To.Text);
            MessageBox.Show(len.ToString());

        }


        //

        public Dictionary<string, string> APIData(string origin, string destination)
        {
            var dataDict = new Dictionary<string, string>();
            try
            {
                string url = $"{BaseUrl}?origins={origin}&destinations={destination}&key={ApiKey}";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (var response = request.GetResponse())
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    string data = streamReader.ReadToEnd();
                    Rootobject rootObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(data);

                    string distance = rootObject.rows[0].elements[0].distance.text;
                    string duration = rootObject.rows[0].elements[0].duration.text;
                    string destinationAddress = rootObject.destination_addresses[0];
                    string originAddress = rootObject.origin_addresses[0];

                    dataDict.Add("Distance", distance);
                    dataDict.Add("Duration", duration);
                    dataDict.Add("Destination", destinationAddress);
                    dataDict.Add("Origin", originAddress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataDict;
        }



        private float APIDataDistance(string Strat, string End)
        {
            string distance = APIData(Strat, End)["Distance"];
            string[] distanceArr = distance.Split(' ');
            return float.Parse(distanceArr[0]);
        }

        private float APIDataDuration(string Strat, string End)
        {
            string duration = APIData(Strat, End)["Duration"];
            string[] durationArr = duration.Split(' ');
            return float.Parse(durationArr[0]);
        }


        private string APIDataDestination(string Strat, string End)
        {
            return APIData(Strat, End)["Destination"];
        }

        private string APIDataOrigin(string Strat, string End)
        {
            return APIData(Strat, End)["Origin"];
        }













    }
}