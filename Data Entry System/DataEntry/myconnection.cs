using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DataEntry
{
    internal class myconnection
    {


        static readonly string server = "elorca.website";
        static readonly string database = "u434118186_Test_Wind";
        static readonly string uid = "u434118186_Badawy";
        static readonly string password = "+d4aT583I";
        static readonly string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        public MySqlConnection mysqlConnection = new MySqlConnection(connectionString);

        public bool Open_DB()
        {
            try
            {
                mysqlConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Close_DB()
        {
            try
            {
                mysqlConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
