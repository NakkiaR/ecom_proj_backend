using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Account
    {
        public string AccountId { get; set; }

        [ForeignKey("IdentityUser")]

        public string IdnetityUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }

        public int PaymentMethodCode { get; set; }

        public string AccountName { get; set; }

        public string AccountDetails { get; set; }
        
    }
}