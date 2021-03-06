using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class Product 
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

   

