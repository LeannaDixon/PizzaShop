using MrPizza.Logging;
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
            Prepare();
            Bake();
            Box();
            Cut();

            return PreparePizza(pizzaType);
        }

        public void Prepare()
        {
            Logger._diagnosticLogger.ForContext<Pizza>()
                .Information("Preparing Pizzs: {PizzaType}", this);

            Logger._diagnosticLogger.ForContext<Pizza>()
                .Information("Adding Toppings: {PizzaType}", this);
        }

        public void Bake()
        {
            Logger._diagnosticLogger.Information("Baking Pizza for 15 minutes at 350");

        }


        public void Box()
        {
            Logger._diagnosticLogger.Information("Placing Pizza into MrPizza Box");
        }

        public void Cut()
        {
            Logger._diagnosticLogger.Information("Cutting Pizza");
        }
    }
}