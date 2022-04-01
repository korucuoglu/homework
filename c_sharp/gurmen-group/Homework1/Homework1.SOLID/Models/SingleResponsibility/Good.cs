using System;

namespace Homework1.SOLID.Models.SingleResponsibility.Good
{
    internal class Good
    {

        public void SendMail(string mail)
        {
            Console.WriteLine($"Mail {mail} adresine gönderildi");
        }

        public void SendPhoneMessage(string phoneNumber)
        {
            Console.WriteLine($"Mesaj {phoneNumber} numarasına gönderildi");
        }

    }

    public class SendNotification
    {
        public string MailAdress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
