using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza.Repository
{
    public class PizzaRepository
    {
        private readonly IPizzaDbContext _context;

        public PizzaRepository(IPizzaDbContext context)
        {
            _context = context;
        }
    }
}
