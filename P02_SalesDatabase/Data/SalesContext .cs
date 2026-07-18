using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_SalesDatabase.Data
{
    internal class SalesContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SalesTask2DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
               .Property(c => c.Email)
               .IsUnicode(false);


            modelBuilder.Entity<Product>()
               .Property(p => p.Description)
               .HasDefaultValue("No description");


            modelBuilder.Entity<Sale>()
              .Property(s => s.Date)
              .HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    ProductId = 1,
                    Name = "Laptop",
                    Quantity = 10,
                    Price = 25000
                },

                new Product
                {
                    ProductId = 2,
                    Name = "Mouse",
                    Quantity = 50,
                    Price = 300
                }

            );

            modelBuilder.Entity<Customer>().HasData(

               new Customer
               {
                   CustomerId = 1,
                   Name = "Ahmed",
                   Email = "ahmed@gmail.com",
                   CreditCardNumber = "1111222233334444"
               },

               new Customer
               {
                   CustomerId = 2,
                   Name = "Youssef",
                   Email = "youssef@gmail.com",
                   CreditCardNumber = "5555666677778888"
               }

            );


            modelBuilder.Entity<Store>().HasData(

                new Store
                {
                    StoreId = 1,
                    Name = "Cairo Store"
                },

               new Store
               {
                   StoreId = 2,
                   Name = "Alex Store"
               }

            );

            modelBuilder.Entity<Sale>().HasData(

               new Sale
               {
                   SaleId = 1,
                   ProductId = 1,
                   CustomerId = 1,
                   StoreId = 1,
                   Date = new DateTime(2026, 7, 18)
               },

               new Sale
               {
                   SaleId = 2,
                   ProductId = 2,
                   CustomerId = 2,
                   StoreId = 2,
                   Date = new DateTime(2026, 7, 19)
               }

            );
        }

    }
}
