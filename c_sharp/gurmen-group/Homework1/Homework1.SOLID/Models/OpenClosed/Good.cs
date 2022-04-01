using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.SOLID.Models.OpenClosed.Good
{
    public class Good
    {

        public double FuelCostCalculate(BaseCar car)
        {
            return car.KM * car.GetCostPerKM();
        }
    }

    public abstract class BaseCar
    {
        public int KM { get; set; }

        public abstract double GetCostPerKM();
    }

    public class Mercedes : BaseCar
    {
        public override double GetCostPerKM()
        {
            return 2;
        }
    }

    public class Mazda : BaseCar
    {
        public override double GetCostPerKM()
        {
            return 1.5;
        }
    }
}
