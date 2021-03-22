using MrPizza.Models;
using System;

namespace MrPizza
{
    public abstract class PizzaStoreFactory
    {
        public PizzaStoreFactory()
        {
        }

        protected abstract Pizza PreparePizza(string pizzaType);
        

        public Pizza CreatePizza(string pizzaType)
        {
            return PreparePizza(pizzaType);
        }
    }
}