using Homework2.Observer.Models;

namespace Homework2.Observer.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders;
        public OrderRepository()
        {
            _orders = new List<Order>()
            {
                  new Order
                   {
                        Id = 1,
                        Products =
                        {
                            new()
                            {
                                Id= 1,
                                Name = "Ürün 1",
                                Color = "Black",
                                Stock = 15

                            },
                            new()
                            {
                                Id= 2,
                                Name = "Ürün 2",
                                Color = "Black",
                                Stock = 15
                            }
                        }
                    },

                  new Order
                        {
                            Id = 2,
                            Products =
                            {
                                new()
                                {
                                    Id= 3,
                                    Name = "Ürün 3",
                                    Color = "Green",
                                    Stock = 15

                                },
                                new()
                                {
                                    Id= 2,
                                    Name = "Ürün 2",
                                    Color = "Yellow",
                                    Stock = 15
                                }
                            }
                        }
            };
        }

        public Order Save(Order order)
        {
            _orders.Add(order);

            return order;
        }

        public List<Order> GetAll()
        {
            return _orders;
        }
    }
}
