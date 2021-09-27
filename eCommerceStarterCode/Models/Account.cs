using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentMethodCode { get; set; }
        public string AccountName { get; set; }
        public string AccountDetails { get; set; }
        
    }
}