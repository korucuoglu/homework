﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Facade.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
    }
}
