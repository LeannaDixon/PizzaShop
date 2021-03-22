using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Details { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
