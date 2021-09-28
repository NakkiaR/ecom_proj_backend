using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace eCommerceStarterCode.Models
//{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
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

        }
//}
