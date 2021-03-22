using Microsoft.EntityFrameworkCore;
using MrPizza.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza.Repository
{
    public interface IPizzaDbContext 
    {
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
