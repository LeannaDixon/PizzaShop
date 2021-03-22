using MrPizza.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza.Factories
{
    public class DeepDishPizza : PizzaStoreFactory
    {
        protected override Pizza PreparePizza(string pizzaType)
        {
            Pizza pizza;
            if (pizzaType == "Vegetarian")
            {
                pizza = new VegetarianPizza();
            }
            pizza = new MargaritaPizza();
            return pizza;
        }
    }
}
