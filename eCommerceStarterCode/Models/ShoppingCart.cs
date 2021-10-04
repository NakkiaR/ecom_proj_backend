using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {

        public int ShoppingCartId { get; set; }

       [ForeignKey("Product")]
        public string ProductId { get; set; }
        public Product Product { get; set; }

       [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser  IdentityUser { get; set; }





    }
}
