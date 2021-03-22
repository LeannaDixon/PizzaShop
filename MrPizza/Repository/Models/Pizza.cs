using MrPizza.Logging;
using System;

namespace MrPizza.Repository.Models
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            Logger._diagnosticLogger.ForContext<Pizza>()
                .Information("Preparing Pizzs: {PizzaType}", this);
        }

        public void Bake()
        {
            Logger._diagnosticLogger.Information("Baking Pizza");

        }

        public void Cut()
        {
            Logger._diagnosticLogger.Information("Cutting Pizza");
        }

        public void Box()
        {
            Logger._diagnosticLogger.Information("Boxing Pizza");
        }
    }
}