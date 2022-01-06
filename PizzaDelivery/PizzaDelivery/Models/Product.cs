using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.Models
{
    public class Product
    {
        public string PizzaName { get; set; }
        public double Price { get; set; }
        public string Ingredients { get; set; }
        public int Size { get; set; }
        public bool IsBitter { get; set; }
        public string img { get; set; }

    }
}
