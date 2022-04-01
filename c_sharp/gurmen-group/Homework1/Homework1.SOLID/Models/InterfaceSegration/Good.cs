using System;
using System.Collections.Generic;

namespace Homework1.SOLID.Models.InterfaceSegration.Good
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
    public interface IEmailMultipleSendable
    {
        void SendMailAll(List<string> mails);
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

    public class Mazda : BaseCar, IEmailSendable, IEmailMultipleSendable
    {
        public override double GetCostPerKM()
        {
            return 1.5;
        }
        public void SendMail(string mail)
        {
            Console.WriteLine($"Mail {mail} adresine gönerildi");
        }

        public void SendMailAll(List<string> mails)
        {
            foreach (var mail in mails)
            {
                SendMail(mail);
            }
        }
    }
}
