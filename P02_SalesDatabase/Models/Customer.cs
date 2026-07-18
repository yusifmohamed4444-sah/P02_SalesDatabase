using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P02_SalesDatabase.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(80)]
        public string Email { get; set; } = null!;
        public string CreditCardNumber { get; set; } = null! ;
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
