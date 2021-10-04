using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FinancialTransaction> FinancialTransactions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());


            modelBuilder.Entity<Category>()
                .HasData(
                new Category { CategoryId = "Zodiac", Name = "Zodiac", Description = "Buying a star in a constellation is an excellent option when it comes to naming a twinkling distant sun. Constellations are always much easier to remember and find, so choose your favorite star sign and name a part of the Zodiac." },
                new Category { CategoryId = "Traditional Star", Name = "Traditional Star", Description = "By choosing our Traditional Star offer, you can adopt a real star in space! Even better, the star you name is one which can be seen anywhere on Earth, at any time of the year. Your star will always be with you!" },
                new Category { CategoryId = "Double Star", Name = "Double Star", Description = "A binary star — or a double star — is a system of two gravitationally-connected stars orbiting around their common center of mass. Double stars are a great choice if you want to buy a star for two people, and even better for celebrating people who have a special connection." }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                new Product { ProductId = "1a", Price = 50, Name = "Star", Description = "It's a star.", CategoryId = "Zodiac" },
                new Product { ProductId = "1b", Price = 50, Name = "Gemini", Description = "May 21 - June 20", CategoryId = "Zodiac" },
                new Product { ProductId = "1c", Price = 50, Name = "Cancer", Description = "June 21 - July 22", CategoryId = "Zodiac" },
                new Product { ProductId = "1d", Price = 50, Name = "Leo", Description = "July 23 - August 22", CategoryId = "Zodiac" },
                new Product { ProductId = "1e", Price = 50, Name = "Virgo", Description = "August 23- September 22", CategoryId = "Zodiac" },
                new Product { ProductId = "1f", Price = 50, Name = "Libra", Description = "September 23 - October 22", CategoryId = "Zodiac" },
                new Product { ProductId = "1g", Price = 50, Name = "Scorpius", Description = "October 23 - November 21", CategoryId = "Zodiac" },
                new Product { ProductId = "1h", Price = 50, Name = "Sagitarius", Description = "November 22 - December 21", CategoryId = "Zodiac" },
                new Product { ProductId = "1i", Price = 50, Name = "Capricorn", Description = "December 22 -January 19", CategoryId = "Zodiac" },
                new Product { ProductId = "1j", Price = 50, Name = "Aquarius", Description = "January 20 - February 19", CategoryId = "Zodiac" },
                new Product { ProductId = "1k", Price = 50, Name = "Pisces", Description = "February 20 - March 20", CategoryId = "Zodiac" },
                new Product { ProductId = "1l", Price = 50, Name = "Aries", Description = "March 21- April 19", CategoryId = "Zodiac" },
                new Product { ProductId = "1m", Price = 50, Name = "Taurus", Description = "April 20 - May 20", CategoryId = "Zodiac" },



                new Product { ProductId = "2a", Price = 35, Name = "Normal", Description = "Can be seen in small villages with minimal light around.", CategoryId = "Traditional Star" },
                new Product { ProductId = "2b", Price = 50, Name = "Bright", Description = "Can be seen in small cities with moderate light around.", CategoryId = "Traditional Star" },
                new Product { ProductId = "2c", Price = 65, Name = "Very Bright", Description = "Can be seen in large cities with a lot of light around.", CategoryId = "Traditional Star" },

                new Product { ProductId = "3a", Price = 70, Name = "Normal", Description = "Can be seen in small villages with minimal light around.", CategoryId = "Double Star" },
                new Product { ProductId = "3b", Price = 85, Name = "Bright", Description = "Can be seen in small cities with moderate light around.", CategoryId = "Double Star" },
                new Product { ProductId = "3c", Price = 110, Name = "Very Bright", Description = "Can be seen in large cities with a lot of light around.", CategoryId = "Double Star" });

            

        }



    }
                



        
    
}

