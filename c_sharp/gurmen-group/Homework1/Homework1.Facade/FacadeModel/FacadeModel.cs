using Homework1.Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Facade
{
    internal class FacadeModel
    {
        private Helper helper =  new();
        internal Order order;

        public void SiparisEkle(User user, List<Product> products)
        {
            order = helper.createOrder(user, products);
            helper.Pay(order.TotalPrice);
            helper.StokGüncelle(products);
            Console.WriteLine("İşlem tamamlandı");
        }

    }
}
