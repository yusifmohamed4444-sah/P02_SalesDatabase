using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P02_SalesDatabase.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

        [MaxLength(250)]
        public string Description { get; set; } = "No description";
    }
}
