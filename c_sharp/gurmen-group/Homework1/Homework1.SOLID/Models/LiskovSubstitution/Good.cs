using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.SOLID.Models.LiskovSubstitution.Good
{
    public class Good
    {

        public double FuelCostCalculate(BaseCar car)
        {
            return car.KM * car.GetCostPerKM();
        }
    }

    public interface IEmailSendable
    {
        void SendMail(string mail);
    }

    public interface ISmsSendable
    {
        void SendSms(string phoneNumber);
    }

    public abstract class BaseCar
    {
        public int KM { get; set; }

        public abstract double GetCostPerKM();
    }

    public class Mercedes : BaseCar, IEmailSendable, ISmsSendable
    {
        public override double GetCostPerKM()
        {
            return 2;
        }

        public void SendMail(string mail)
        {
            Console.WriteLine($"Mail {mail} adresine gönerildi");
        }

        public void SendSms(string phoneNumber)
        {
            Console.WriteLine("SMS gönerildi");
        }
    }

    public class Mazda : BaseCar, IEmailSendable
    {
        public override double GetCostPerKM()
        {
            return 1.5;
        }
        public  void SendMail(string mail)
        {
            Console.WriteLine($"Mail {mail} adresine gönerildi");
        }
       
    }
}
