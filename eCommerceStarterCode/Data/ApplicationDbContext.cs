﻿using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DBSet<Account> Accounts { get; set; }
        public DBSet<Category> Categories { get; set; }
        public DBSet<FinancialTransaction> FinancialTransactions { get; set; }
        public DBSet<Order> Orders { get; set; }
        public DBSet<PaymentMethod> PaymentMethods { get; set; }
        public DBSet<Product> Products { get; set; }
        public DBSet<Shipment> Shipments { get; set; }
        public DBSet<ShoppingCart> ShoppingCarts { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasData(
                new Product { Price = 35, Name = "Star", Description = "It's a star.", Category = "Red Giant" }
                );
        }

    }
}
