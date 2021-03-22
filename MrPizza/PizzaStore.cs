using MrPizza.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza
{
    public class PizzaStore
    {
        private readonly PizzaStoreFactory _pizzaFactory;

        public PizzaStore(PizzaStoreFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public Pizza OrderPizza(string type)
        {
            var pizza = _pizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
