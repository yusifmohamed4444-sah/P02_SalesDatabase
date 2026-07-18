using System;
using System.Collections.Generic;
using System.Text;

namespace P02_SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date {  get; set; }
        public int ProductId {  get; set; }
        public Product? Product { get; set; }
        public int CustomerId {  get; set; }
        public Customer? customer { get; set; } 
        public int StoreId  {  get; set; }
        public Store? Store { get; set; } 

    }
}
