using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required, MinLength(3)]
        public string FirstName { get; set; }
        [Required, MinLength(3)]
        public string LastName { get; set; }
        [Required, MinLength(3)]
        public string FirstLineOfAddress { get; set; }
        [Required, MinLength(3)]
        public string SecondLineOfAddress { get; set; }
        [Required, MinLength(3)]
        public string City { get; set; }
        [Required, MinLength(3)]
        public string County { get; set; }
        [Required, MinLength(3)]
        public string Country { get; set; }
        [Required, MinLength(4)]
        public string Postcode { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public int MobileNumber { get; set; }

       // [ForeignKey("Order")]
        public ICollection<Order>? Orders { get; set; }
    }
}
