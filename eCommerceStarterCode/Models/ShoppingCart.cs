using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {

        [ForeignKey("Identity User")]

        public string 

        public int ProductId { get; set; }
        public int UserId { get; set; }

        
       
    }
}
