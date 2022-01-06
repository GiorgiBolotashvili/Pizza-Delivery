using PizzaDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.Mocks
{
    public class MocksPizzeys
    {
        public IEnumerable<Pizza> Pizzeys { get {
                return new List<Pizza>
                { new Pizza{ PizzaName = "Margherita", Ingredients = "San Marzano tomato sauce, Mozzarella di bufala, Olive Oil" },
                new Pizza{ PizzaName = "Marinara", Ingredients = "Marinara sauce, Garlic, Olive oil, Basil, Oregano" },
                new Pizza{ PizzaName = "Calabrese", Ingredients = "Tomato sauce, Parmigian Reggiano (Parmesan), Tuna, Olives, Capers, Garlic, Onion, Hot Calabrian chili peppers" },
                new Pizza{ PizzaName = "Contadina", Ingredients = "Tomato sauce, Mozzarella, Eggplants, Artichokes, Garlic, Basil" },
                new Pizza{ PizzaName = "Salmone", Ingredients = "Tomato sauce, Mascarpone cheese, Smoked salmon and rocket salad (arugula)"},
                new Pizza{ PizzaName = "Siciliana", Ingredients = "Tomato sauce, Mozzarella, Garlic, Salami, Hot peppers, Olive oil" },
                new Pizza{ PizzaName = "Buffalo Chicken", Ingredients = "Hot sauce, Monterey Jack cheese, Blue cheese, Chicken breast cutlets, Spring onions, Olive oil" },
                new Pizza{ PizzaName = "Longaniza", Ingredients = "	Tomato slices, Red chili peppers, Longaniza (Spanish sausage)"},
                new Pizza{ PizzaName = "Peperone", Ingredients = "Tomato sauce, Emmenthaler cheese, Parmesan, Peperoni salami, Chili peppers" }
                };
            } }
    }
}
