using PizzaDelivery.Mocks;
using PizzaDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.ViewModels
{
    public class PizzaViewModel
    {
        public User User { get; set; }
        public MocksPizzeys Pizzeys { get; set; }
    }
}
