using System;

namespace Homework1.SOLID.Models.SingleResponsibility.Bad
{
    internal class Bad
    {

        public void SendMessage(SendNotification sendNotification)
        {
            if (!string.IsNullOrEmpty(sendNotification.MailAdress))
            {
                Console.WriteLine("Mail gönderildi");
            }

            if (!string.IsNullOrEmpty(sendNotification.PhoneNumber))
            {
                Console.WriteLine("Mesaj gönderildi");
            }
        }

    }

    public class SendNotification
    {
        public string MailAdress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
