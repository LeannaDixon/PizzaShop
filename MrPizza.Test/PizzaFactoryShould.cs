using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using MrPizza.Repository.Models;
using NUnit.Framework;


namespace MrPizza.Test
{
    class PizzaFactoryShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //[TestCase("Vegetarian")]
        [TestCase("Margarita")]
        public void CreateTheExpectedPizzaType(string expectedPizzaType)
        {
            var pizzaStore = new PizzaStoreFactory();
            pizzaStore.CreatePizza(expectedPizzaType).Should().BeOfType<MargaritaPizza>();
        }
    }
}
