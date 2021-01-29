using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace My_AIS_Cars.Model.Tools
{
    class ConnectionManager
    {
         public static MySqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;User=root;Password=211994Z;Database=my_ais_cars;";

            return new MySqlConnection(connectionString);
        }
    }
}
