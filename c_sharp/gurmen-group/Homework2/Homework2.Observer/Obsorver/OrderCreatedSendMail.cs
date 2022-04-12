using Homework2.Observer.Models;

namespace Homework2.Observer.Obsorver
{
    public class OrderCreatedSendMail : IOrder
    {
        public void OrderCreated(Order order)
        {
            Console.WriteLine($"Email => Yeni siparişiniz var. Sipariş Numarası: {order.Id}");
        }
    }
}
