using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using MrPizza.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace MrPizza.Test
{
    public class PizzaRepositoryShould
    {
        private Mock<IPizzaDbContext> _context;

        [SetUp]
        public void Setup()
        {
            _context = new Mock<IPizzaDbContext>();
            
        }

        [Test]
        public void GetAllPizzas()
        {
            _context.GetAllPizzas.Should().Be(0);
        }

    } 
}
