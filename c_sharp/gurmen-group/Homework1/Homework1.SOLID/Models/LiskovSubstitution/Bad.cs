using System;

namespace Homework1.SOLID.Models.LiskovSubstitution.Bad
{
    public class Bad
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

        public abstract void SendMail(string mail);
        public abstract void SendSms(string phoneNumber);
    }

    public class Mercedes : BaseCar
    {
        public override double GetCostPerKM()
        {
            return 2;
        }

        public override void SendMail(string mail)
        {
            Console.WriteLine($"Mail {mail} adresine gönerildi");
        }

        public override void SendSms(string phoneNumber)
        {
            Console.WriteLine("SMS gönerildi");
        }
    }

    public class Mazda : BaseCar
    {
        public override double GetCostPerKM()
        {
            return 1.5;
        }

        public override void SendMail(string mail)
        {
            Console.WriteLine($"Mail {mail} adresine gönerildi");
        }

        public override void SendSms(string phoneNumber)
        {
            throw new Exception("SMS gönderilemez");
        }
    }
}
