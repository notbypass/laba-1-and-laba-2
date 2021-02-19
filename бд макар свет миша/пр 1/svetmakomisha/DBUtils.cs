using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace svetmakomisha
{
    class DBUtils
    {
        public static MySqlConnection GetMySqlConnection()
        {
            string host = "192.168.70.5";
            int port = 3306;
            string database = "Makar";
            string username = "appuser";
            string password = "pass";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}