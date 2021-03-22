using Microsoft.EntityFrameworkCore;
using MrPizza.Repository;
using MrPizza.Repository.Models;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MrPizza.Test
{
    public class OrderControllerShould
    {
        public IPizzaDbContext _context;
        [SetUp]
        public void Setup()
        {
            // Need to use NSubstitute to sub in our dbContext.
            // To seed the data, we need to set the return to an IQueryable.
            _context = Substitute.For<IPizzaDbContext>();
            IQueryable<Pizza> newPizzas = new List<Pizza>() 
                            {
                                new MargaritaPizza(),
                                new VegetarianPizza()
                            }
                             .AsQueryable();

            _context.Pizzas.Returns(newPizzas);
        }

        [Test]
        public void CreateNewOrder()
        {
            
        }
    }
}
