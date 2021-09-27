using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class PaymentMethods
    {
        public int PaymentCodeId { get; set; }
        public string Name { get; set; }
        public int CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CVV { get; set; }
        public string CardType { get; set; }
        public string BillingZip { get; set; }

    }
}