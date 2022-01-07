using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.Services
{
    public class Time : ILocalTime
    {
        public string LocalTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
