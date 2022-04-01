using Homework1.Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework1.Facade
{
    internal class Helper
    {
        public Order createOrder(User user, List<Product> products)
        {
            Random rnd = new();

            return new Order()
            {
                Id = rnd.Next(1, 9999999),
                Products = products,
                User = user,
                TotalPrice = products.Sum(x => x.Price)
            };
        }

        public void Pay(double price)
        {
            Console.WriteLine($"{price} TL ödeme başarıyla alındı");
        }

        public void StokGüncelle(List<Product> products)
        {
            products.ForEach(x => x.Stock -= 1);
        }
    }
}
