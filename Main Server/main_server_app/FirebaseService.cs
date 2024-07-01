using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Streaming;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace MainServer
{
    public class FirebaseService
    {
        private IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Ssanw9rmCXkVYABLZ9pjCX0CECOgIM3bPBCs6zv6",
            BasePath = "https://careconnect-1c393-default-rtdb.firebaseio.com/"
        };

        private FirebaseClient firebaseClient;
        private IFirebaseClient client;
        string url = "";
        Rootobject rootobject;
        private const string ApiKey = "PITmMtX8zjb9IeC4sjnmTiWT8zCCyp3uSvJ4QCjyENxapT6vaPGtmrZOcbHuLFLP";
        private const string BaseUrl = "https://api.distancematrix.ai/maps/api/distancematrix/json";

     
    }
}
