using Homework2.Observer.Models;

namespace Homework2.Observer.Obsorver
{
    public class OrderContext
    {
        private readonly List<IOrder> _orders;

        public OrderContext()
        {
            _orders = new List<IOrder>();
        }

        public void RegisterObserver(IOrder obsorver)
        {
            _orders.Add(obsorver);
        }

        public void RunObservers(Order order)
        {
            _orders.ForEach(x =>
            {
                x.OrderCreated(order);
            });
        }
    }
}
