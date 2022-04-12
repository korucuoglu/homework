using Homework2.Observer.Models;

namespace Homework2.Observer.Obsorver
{
    public class OrderCreatedSendSms: IOrder
    {
        public void OrderCreated(Order order)
        {
            Console.WriteLine($"SMS => Yeni siparişiniz var. Sipariş Numarası: {order.Id}");
        }
    }
}
