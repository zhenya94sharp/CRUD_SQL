using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_AIS_Cars.Model.Entities
{
    class ModelCar
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return Model;
        }
    }
}
