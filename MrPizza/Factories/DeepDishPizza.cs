﻿using MrPizza.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza.Factories
{
    public class DeepDishPizza : PizzaStoreFactory
    {
        public DeepDishPizza()
        {
                
        }
        protected override Pizza PreparePizza(string pizzaType)
        {
            Pizza pizza;
            if (pizzaType == "Vegetarian")
            {
                pizza = new VegetarianPizza();
            }
            else if (pizzaType == "Pepperoni")
            {
                pizza = new PepperoiPizza();
            }
            else
            {
                pizza = new MargaritaPizza();
            }
            pizza.Crust = "Deep dish";

            return pizza;
        }
    }
}
