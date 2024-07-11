using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reception_App
{
    internal class myconnection
    {
        public static MySqlConnection connection;
        static readonly string server = "elorca.website";
        static readonly string database = "u434118186_Test_Wind";
        static readonly string uid = "u434118186_Badawy";
        static readonly string password = "+d4aT583I";
        static readonly string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        public static void set_myconnection()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public static void add_sql(string sql)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
