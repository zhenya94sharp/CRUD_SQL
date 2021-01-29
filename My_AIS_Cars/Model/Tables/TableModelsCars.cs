using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_AIS_Cars.Model.Entities;
using MySql.Data.MySqlClient;

namespace My_AIS_Cars.Model.Tables
{
    class TableModelsCars
    {
        private List<ModelCar> cars;

        private MySqlCommand mySqlCommand;

        public List<ModelCar> Rows
        {
            get { return cars; }
        }

        public TableModelsCars(MySqlCommand mySqlCommand)
        {
             this.mySqlCommand = mySqlCommand;

             cars=new List<ModelCar>();

             SelectModelsFromDb();
        }

        private void SelectModelsFromDb()
        {
            mySqlCommand.CommandText = "SELECT * FROM `models_cars`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            cars.Clear();

            while (reader.Read())
            {
                cars.Add(new ModelCar()
                {
                    Id = reader.GetInt32("id"),
                    Model = reader.GetString("model")
                });
            }

            reader.Close();
        }


    }
}
