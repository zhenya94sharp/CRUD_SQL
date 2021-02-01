﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_AIS_Cars.Model.Entities;
using MySql.Data.MySqlClient;

namespace My_AIS_Cars.Model.Tables
{
    class TableCars
    {
        private List<Car> cars;

        private MySqlCommand mySqlCommand;

        public List<Car> Rows
        {
            get
            {
                return cars;
            }
        }

        public TableCars(MySqlCommand mySqlCommand, TableModelsCars modelsCars)
        {
            this.mySqlCommand = mySqlCommand;

            cars = new List<Car>();

            SelectCarsFromDb(modelsCars);
        }

        private void SelectCarsFromDb(TableModelsCars tableModels)
        {

            mySqlCommand.CommandText = "CALL cars_select_all()";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            cars.Clear();


            while (reader.Read())
            {
                cars.Add(new Car()
                {
                    Id = reader.GetInt32("id"),
                    idModel = reader.GetInt32("id_model"),
                    Body = reader.GetString("body"),
                    Year = reader.GetDateTime("year"),
                    Balance = reader.GetInt32("balance"),
                    Price = reader.GetInt32("price"),
                    Credit = reader.GetBoolean("credit"),
                    model = tableModels.Rows.Find(item => item.Id == reader.GetInt32("id_model"))
                });
            }

            reader.Close();

        }

        private int ConvertBooleanForMysql(bool creditStatus)
        {
            return creditStatus ? 1 : 0;
        }

        public void DeleteCarByID(int id)
        {
            mySqlCommand.CommandText = $"CALL cars_delete_by_id({id});";

            int selectedRow = mySqlCommand.ExecuteNonQuery();

            if (selectedRow == 1)
            {
                cars.Remove(cars.Find(item => item.Id == id));
            }
        }

        public void AddNewCar(Car car)
        {
            mySqlCommand.CommandText = $"CALL cars_insert_new('{car.idModel}','{car.Body}','{car.Year.ToString("yyyy-MM-dd")}','{car.Balance}','{car.Price}','{ConvertBooleanForMysql(car.Credit)}');";


           /* mySqlCommand.Parameters.AddWithValue("@id_model", car.idModel);
            mySqlCommand.Parameters.AddWithValue("@body", car.Body);
            mySqlCommand.Parameters.AddWithValue("@year", car.Year);
            mySqlCommand.Parameters.AddWithValue("@balance", car.Balance);
            mySqlCommand.Parameters.AddWithValue("@price", car.Price);
            mySqlCommand.Parameters.AddWithValue("@credit", car.Credit);*/

            int selectedRow = mySqlCommand.ExecuteNonQuery();

            if (selectedRow == 1)
            {
                mySqlCommand.CommandText = "SELECT LAST_INSERT_ID()";

                car.Id = Convert.ToInt32(mySqlCommand.ExecuteScalar());

                cars.Add(car);
            }
        }

        public void ClearAllCar()
        {
            mySqlCommand.CommandText = "CALL cars_truncate();";
            mySqlCommand.ExecuteNonQuery();
        }

        public void UpdateCar(Car car)
        {
            mySqlCommand.CommandText =
                $"CALL cars_update('{car.idModel}','{car.Body}','{car.Year.ToString("yyyy-MM-dd")}','{car.Balance}','{car.Price}','{car.Id}','{ConvertBooleanForMysql(car.Credit)}');";

            int selectedRow = mySqlCommand.ExecuteNonQuery();

            if (selectedRow == 1)
            {
                mySqlCommand.CommandText = "SELECT LAST_INSERT_ID()";

                car.Id = Convert.ToInt32(mySqlCommand.ExecuteScalar());

                cars.Insert(car.Id,car);
            }
        }


    }
}
