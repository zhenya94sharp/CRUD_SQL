using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_AIS_Cars.Model.Entities
{
    class Car
    {
        public int Id { get; set; }
        public int idModel { get; set; }
        public ModelCar model { get; set; }
        public string Body { get; set; }
        public DateTime Year { get; set; }
        public int Balance { get; set; }
        public int Price { get; set; }
        public bool Credit { get; set; }

    }
}
