using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_data_update_App
{
    public static class FirebaseConnection
    {
        public static IFirebaseConfig connection = new FirebaseConfig
        {
            AuthSecret = "Ssanw9rmCXkVYABLZ9pjCX0CECOgIM3bPBCs6zv6",
            BasePath = "https://careconnect-1c393-default-rtdb.firebaseio.com/"
        };
        public static IFirebaseClient GetFirebaseConnection()
        {
            return new FireSharp.FirebaseClient(connection);
        }
        
        
    }
}
