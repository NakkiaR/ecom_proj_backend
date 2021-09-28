using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        [ForeignKey("User")]

        public int UserId { get; set; }

        public User User { get; set; }

        public int PaymentMethodCode { get; set; }

        public string AccountName { get; set; }

        public string AccountDetails { get; set; }
        
    }
}