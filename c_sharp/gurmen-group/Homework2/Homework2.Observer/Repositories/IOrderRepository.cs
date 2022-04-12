using Homework2.Observer.Models;

namespace Homework2.Observer.Repositories
{
    public interface IOrderRepository
    {
        public List<Order> GetAll();
        public Order Save(Order order);
    }
}
