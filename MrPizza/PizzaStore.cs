using MrPizza.Logging;
using MrPizza.Models;
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

            Logger._diagnosticLogger.Information("Creating Pizza {type}", type);
            return pizza;
        }
    }
}
