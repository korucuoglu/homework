using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.SOLID.Models.OpenClosed.Bad
{
    public class Bad
    {

        public double FuelCostCalculate(BaseCar car)
        {
            if (car is Mercedes)
            {
                return car.KM * 3.5;
            }
            else if (car is Mazda)
            {
                return car.KM * 1.5;
            }
            else
            {
                return car.KM;
            }
        }
    }

    public class BaseCar
    {
        public int KM { get; set; }
    }

    public class Mercedes: BaseCar
    {

    }

    public class Mazda: BaseCar
    {

    }
}
