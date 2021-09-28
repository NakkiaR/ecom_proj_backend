﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Review
    {

        public int ReviewId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public int Rating { get; set; }


        [ForeignKey("ProductId")]

        public int ProductId { get; set; }

        public Product Product { get; set; }


        [ForeignKey("UserId")]

        public int UserId { get; set; }

        public User User { get; set; }

    }
}
