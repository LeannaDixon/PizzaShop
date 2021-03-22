using MrPizza.Logging;
using System;
using System.Collections.Generic;

namespace MrPizza.Models
{
    public abstract class Pizza
    {
        private readonly string _name;
        private readonly string _crust;
        private readonly string _sauce;
        private readonly List<string> _toppings = new List<string>();

        public string Crust 
        { 
            get
            {
                return _crust;
            }
            set
            {
                value = _crust;
            } 
        }

        public string Sauce
        {
            get
            {
                return _sauce;
            }
            set
            {
                value = _sauce;
            }
        }

        public List<string> Toppings
        {
            get
            {
                return _toppings;
            }
            set
            {
                foreach (var item in value)
                {
                    _toppings.Add(item);
                }
            }
        }

        public string Name { get { return _name; } set { value = _name; } }

        public Pizza()
        {
            Toppings.Add("Mozzarella");
            Toppings.Add("Basil");
            Sauce = "Tomato";
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

        public string GetName()
        {
            return Name;
        }
    }
}