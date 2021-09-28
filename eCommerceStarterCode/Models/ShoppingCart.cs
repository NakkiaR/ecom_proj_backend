using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {

        public int ShoppingCartId { get; set; }

        [ForeignKey("Product")]

        public int ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey("User")]

        public int UserId { get; set; }

        public User User { get; set; }

        
       
    }
}
