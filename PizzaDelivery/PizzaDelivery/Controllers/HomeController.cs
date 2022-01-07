using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.Mocks;
using PizzaDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User user = new User();
            return View(user);
        }
        public IActionResult Registration(User user, Address address)
        {
            user.MyAdress = new Address { StreetName = address.StreetName };

            return View(user);
        }

        public IActionResult OrderPizza(int count)
        {
            MocksPizzeys pizzeys = new MocksPizzeys();
            ViewBag.count = count;
            return View(pizzeys);
        }

        public IActionResult SetProduct(Product[] products)
        {
            MocksPizzeys pizzeys = new MocksPizzeys();
            foreach (var item in pizzeys.Pizzeys)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (item.PizzaName== products[i].PizzaName)
                    {
                        products[i].Ingredients = item.Ingredients;
                    }
                }
            }
            return View(products);
        }
    }
}
