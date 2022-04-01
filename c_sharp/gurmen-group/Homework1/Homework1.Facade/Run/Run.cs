using Homework1.Facade.Models;
using System;
using System.Collections.Generic;

namespace Homework1.Facade
{
    internal static class Run
    {
        public static void Bad()
        {
            Random rnd = new();
            Helper helper = new();

            var products = new List<Product>()
            {
                new Product(){Id = rnd.Next(1, 9999999), Stock=99, Name = "Ürün 1",   Price = rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=11, Name = "Ürün 2",   Price = rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=14, Name = "Ürün 3",   Price =  rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=1123, Name = "Ürün 4", Price =  rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=1490, Name = "Ürün 5",  Price = rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=87, Name = "Ürün 6",    Price = rnd.Next(1, 200)},
            };

            var user = new User()
            {
                Id = rnd.Next(1, 9999999),
                Name = "Abdullah Halit Korucuoğlu"
            };

            var order = helper.createOrder(user, products);
            helper.Pay(order.TotalPrice);
            helper.StokGüncelle(products);
            Console.WriteLine("İşlem tamamlandı");
        }

        public static void Good()
        {
            Random rnd = new();

            var products = new List<Product>()
            {
                new Product(){Id = rnd.Next(1, 9999999), Stock=99, Name = "Ürün 1",   Price = rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=11, Name = "Ürün 2",   Price = rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=14, Name = "Ürün 3",   Price =  rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=1123, Name = "Ürün 4", Price =  rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=1490, Name = "Ürün 5",  Price = rnd.Next(1, 200)},
                new Product(){Id = rnd.Next(1, 9999999), Stock=87, Name = "Ürün 6",    Price = rnd.Next(1, 200)},
            };


            var user = new User()
            {
                Id = rnd.Next(1, 9999999),
                Name = "Abdullah Halit Korucuoğlu"
            };

            FacadeModel facade = new();
            facade.SiparisEkle(user, products);

        }
    }
}

