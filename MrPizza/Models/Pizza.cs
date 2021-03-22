using MrPizza.Logging;
using System;
using System.Collections.Generic;

namespace MrPizza.Models
{
    public abstract class Pizza
    {
        private string _name;
        private string _crust;
        private string _sauce;
        private IList<string> _toppings = new List<string>();

        public string Crust 
        { 
            get => _crust;
            set
            {
                _crust = value;
            } 
        }

        public string Sauce
        {
            get => _sauce;
            set
            {
                _sauce = value;
            }
        }

        public ICollection<string> Toppings
        {
            get => _toppings;
            set
            {
                foreach (var item in value)
                {
                    _toppings.Add(item);
                }
            }
        }

        public string Name { get { return _name; } set { _name = value; } }

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