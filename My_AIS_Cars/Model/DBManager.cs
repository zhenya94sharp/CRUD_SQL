using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_AIS_Cars.Model.Tables;
using My_AIS_Cars.Model.Tools;
using MySql.Data.MySqlClient;

namespace My_AIS_Cars.Model
{
    class DBManager
    {
        private static DBManager instance;
        private MySqlConnection mySqlConnection;

        public TableCars TableCars { get; private set; }
        public TableModelsCars TableModels { get; private set; }

        private DBManager()
        {
            mySqlConnection = ConnectionManager.GetConnection();

            mySqlConnection.Open();

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            TableModels=new TableModelsCars(mySqlCommand);

            TableCars=new TableCars(mySqlCommand,TableModels);

        }

        public static DBManager GetInstance()
        {
            if (instance==null)
            {
                instance=new DBManager();
            }

            return instance;
        }


        public void Reopen()
        {
            mySqlConnection.Open();
        }

        ~DBManager()
        {
            mySqlConnection.Close();
        }

    }
}
