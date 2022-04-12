using Homework2.Observer.Models;

namespace Homework2.Observer.Obsorver
{
    public interface IOrder
    {
        public void OrderCreated(Order order);
    }
}
