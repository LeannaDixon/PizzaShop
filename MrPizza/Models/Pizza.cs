using Microsoft.EntityFrameworkCore;
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
        private ICollection<string> _toppings = new List<string>();

        [BackingField(nameof(_crust))]
        public string Crust { get => _crust; set { _crust = value; } }

        [BackingField(nameof(_sauce))]
        public string Sauce { get => _sauce; set { _sauce = value; } }

        [BackingField(nameof(_toppings))]
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
    

        [BackingField(nameof(_name))]
        public string Name { get { return _name; } set { _name = value; } }

        public Pizza()
        {
            Toppings.Add("Mozzarella");
            Toppings.Add("Basil");
            Sauce = "Tomato";
        }
       

        public string GetName()
        {
            return Name;
        }
    }
}