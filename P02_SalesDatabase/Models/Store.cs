using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P02_SalesDatabase.Models
{
    internal class Store
    {
        public int StoreId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = null!;
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

    }
}
