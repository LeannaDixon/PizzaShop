using System;

namespace MrPizza.Repository.Models
{
    public abstract class Pizza
    {
        public Pizza Prepare()
        {
            
        }

        public Pizza Bake()
        {
        }

        public Pizza Cut()
        {
            throw new NotImplementedException();
        }

        public Pizza Box()
        {
            throw new NotImplementedException();
        }
    }
}