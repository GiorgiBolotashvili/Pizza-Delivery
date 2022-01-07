using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.Mocks;
using PizzaDelivery.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.Controllers
{
    public class HomeController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _appEnvironmrnt;
        private User user { get; set; }
        static string firstName;
        static string lastName;

        [Obsolete]
        public HomeController(IHostingEnvironment environment)
        {
            _appEnvironmrnt = environment;
        }
        public IActionResult Index()
        {

            return View(user);
        }
        public IActionResult Registration(User user, Address address)
        {
            user.MyAdress = new Address { StreetName = address.StreetName };

            firstName = user.FirstName;
            lastName = user.LastName;
            return View(user);
        }

        public IActionResult OrderPizza(int count)
        {
            MocksPizzeys pizzeys = new MocksPizzeys();
            ViewBag.count = count;
            return View(pizzeys);
        }

        [Obsolete]
        public IActionResult SetProduct(Product[] products)
        {
            MocksPizzeys pizzeys = new MocksPizzeys();
            foreach (var item in pizzeys.Pizzeys)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (item.PizzaName == products[i].PizzaName)
                    {
                        products[i].Ingredients = item.Ingredients;
                    }
                }
            }
            string path = _appEnvironmrnt.ContentRootPath + "/Files/file.txt";
            System.IO.File.Delete(path);

            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            using (StreamWriter streamFile = new StreamWriter(file))
            {
                foreach (var item in products)
                {
                    streamFile.WriteLine("Name: " + item.PizzaName);
                    streamFile.WriteLine("Ingredients: " + item.Ingredients);
                    if (item.IsBitter)
                    {
                        streamFile.WriteLine("Is better");
                    }
                    else
                    {
                        streamFile.WriteLine("Is not better");
                    }
                    if (item.Size == 1)
                    {
                        streamFile.WriteLine("Size is small: 4 Pieces");
                    }
                    else if (item.Size == 2)
                    {
                        streamFile.WriteLine("Size is medium: 6 Pieces");
                    }
                    else
                    {
                        streamFile.WriteLine("Size is large: 8 Pieces");
                    }
                }
                streamFile.WriteLine("File Created !" + DateTime.Now.ToLongDateString());
            }
            file.Close();

            string fileName = firstName + "." + lastName + "'s order.txt";

            return PhysicalFile(path, "Application/txt", fileName);
        }
    }
}
