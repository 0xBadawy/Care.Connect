using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace MainServer
{
    public class DistanceService
    {

        private const string ApiKey = "PITmMtX8zjb9IeC4sjnmTiWT8zCCyp3uSvJ4QCjyENxapT6vaPGtmrZOcbHuLFLP";
        private const string BaseUrl = "https://api.distancematrix.ai/maps/api/distancematrix/json";
        Dictionary<string, string> HospitalDataDictionary = new Dictionary<string, string>();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Ssanw9rmCXkVYABLZ9pjCX0CECOgIM3bPBCs6zv6",
            BasePath = "https://careconnect-1c393-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;






        public void LoadDataFromDatabase()
        {
            Dictionary<string, string> HospitalDataDictionaryTemp = new Dictionary<string, string>();
            try
            {
                client = new FireSharp.FirebaseClient(config);

                FirebaseResponse response = client.Get("CareConnect/HospitalData");
                var data = response.ResultAs<Dictionary<string, HospitalData>>();

                // print data 

                string dataString = "Data \n\n";
                foreach (var item in data)
                {
                    dataString += item.Key + " : " + item.Value.Address + "\n";
                    string primartKey = item.Key;
                }
                MessageBox.Show(dataString);

                if (data != null)
                {
                    foreach (var item in data)
                    {
                       HospitalDataDictionaryTemp.Add(item.Key, item.Value.Address);
                    }
                    HospitalDataDictionary = HospitalDataDictionaryTemp;
                }
                else
                {
                    MessageBox.Show("No data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public void CalculateDistance(string location)
        {
            string x = "", y = "";
            try
            {
                x = location.Split(',')[0];
                y = location.Split(',')[1];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Tuple<double, double> MyLocation = Tuple.Create(double.Parse(x), double.Parse(y));

            Dictionary<string, double> Distance = CalculateDistance(HospitalDataDictionary, MyLocation);

            string result = "";
            result += "First 5 Nerest Hospital Linear: \n";
            result += "------------------------\n";

            foreach (var item in Distance)
            {

                // string Tr=
                result += "Hospital " + item.Key + " : " + (ConvertToKilometers(item.Value)).ToString().Substring(0, 6) + " KM (linear) \n";

                string Hospitallocation = HospitalDataDictionary[item.Key] + "," + HospitalDataDictionary[item.Key];

                //double Res= APIDataDistance(location, Hospitallocation);

                //         result += (item.Key + " : " + Res + "" + "\n");

            }

            ConfigurationManager.AppSettings["StatusText"] += result + "\n\n\n";

           // UpdateStatusTextBox(StatusText);




        }

        public Dictionary<string, double> CalculateDistanceAPI(string location)
        {
            string x = "", y = "";
            try
            {
                x = location.Split(',')[0];
                y = location.Split(',')[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new Dictionary<string, double>(); // Return an empty dictionary in case of an error
            }

            Tuple<double, double> MyLocation = Tuple.Create(double.Parse(x), double.Parse(y));

            Dictionary<string, double> Distance = CalculateDistance(HospitalDataDictionary, MyLocation);


            List<Tuple<string, double, double>> results = new List<Tuple<string, double, double>>();

            string result = "";
            foreach (var item in Distance)
            {
                string Hospitallocation = HospitalDataDictionary[item.Key];
                double ResAPI = APIDataDistance(location, Hospitallocation);
                double ResAPI2 = APIDataDuration(location, Hospitallocation);

                results.Add(new Tuple<string, double, double>(item.Key, ResAPI, ResAPI2));
            }

            results.Sort((x, y) => x.Item2.CompareTo(y.Item2));

            Dictionary<string, double> DistanceValuesAPI = new Dictionary<string, double>();

            foreach (var item in results)
            {
                string distance = item.Item2.ToString();
                string duration = item.Item3.ToString();

                if (distance.Length > 5)
                    distance = distance.Substring(0, 5);

                if (duration.Length > 5)
                    duration = duration.Substring(0, 5);

                // Update result string for demonstration purposes
                result += $"Hospital {item.Item1} : {distance} KM - Time {duration} Minutes\n";
                // Console.WriteLine(result); // Replace this with whatever you want to do with the result string
                DistanceValuesAPI.Add(item.Item1, item.Item2);
            }
            ConfigurationManager.AppSettings["StatusText"] += result + "\n\n\n";

            return DistanceValuesAPI;
        }






        public Dictionary<string, string> APIData(string origin, string destination)
        {
       //     MessageBox.Show("APi " + origin + "\n" + destination);
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

                    if (rootObject != null && rootObject.rows != null && rootObject.rows.Length > 0 &&
                        rootObject.rows[0].elements != null && rootObject.rows[0].elements.Length > 0)
                    {
                        string distance = rootObject.rows[0].elements[0].distance?.text ?? "Distance not available";
                        string duration = rootObject.rows[0].elements[0].duration?.text ?? "Duration not available";
                        string destinationAddress = rootObject.destination_addresses?[0] ?? "Destination address not available";
                        string originAddress = rootObject.origin_addresses?[0] ?? "Origin address not available";

                        dataDict.Add("Distance", distance);
                        dataDict.Add("Duration", duration);
                        dataDict.Add("Destination", destinationAddress);
                        dataDict.Add("Origin", originAddress);
                    }
                    else
                    {
                        MessageBox.Show("Error parsing API response: Data structure is unexpected.");
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Error retrieving API data: {ex.Message}");
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Error parsing JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return dataDict;
        }
        private float APIDataDistance(string Strat, string End)
        {
            try
            {
                string distance = APIData(Strat, End)["Distance"];
                string[] distanceArr = distance.Split(' ');
                return float.Parse(distanceArr[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
        private float APIDataDuration(string Strat, string End)
        {
            try
            {

            string duration = APIData(Strat, End)["Duration"];
            string[] durationArr = duration.Split(' ');
            return float.Parse(durationArr[0]);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private string APIDataDestination(string Strat, string End)
        {
            return APIData(Strat, End)["Destination"];
        }
        private string APIDataOrigin(string Strat, string End)
        {
            return APIData(Strat, End)["Origin"];
        }

        public Dictionary<string, double> CalculateDistance(Dictionary<string, string> data, Tuple<double, double> MyLocation)
        {

            Dictionary<string, double> diatace = new Dictionary<string, double>();
            foreach (var item in data)
            {
                string[] parts = item.Value.Split(',');
                double Locationx = double.Parse(parts[0]);
                double Locationy = double.Parse(parts[1]);


                double x = Math.Pow((Locationx - MyLocation.Item1), 2);
                double y = Math.Pow((Locationy - MyLocation.Item2), 2);
                double distance = Math.Sqrt(x + y);
                diatace[item.Key] = (float)distance;
            }

            Dictionary<string, double> Distance = diatace;
            Distance = Distance.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return Distance.Take(5).ToDictionary(x => x.Key, x => x.Value);
        }

        public static float ConvertToKilometers(double distanceInDegrees)
        {
            const double degreesToKilometers = 111; // Approximate conversion factor
            return (float)(distanceInDegrees * degreesToKilometers);
        }

    }
}
