using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Review
    {

        public string ReviewId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }


        [ForeignKey("Category")]

        public int CategoryId { get; set; }

        public Category Category { get; set; }


        [ForeignKey("User")]

        public string UserId { get; set; }

        public User User { get; set; }

    }
}
