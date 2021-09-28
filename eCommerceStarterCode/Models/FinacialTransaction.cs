using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class FinacialTransaction
    {
        public int TransactionId { get; set; }
        
        public int PreviousTransactionId { get; set; }
        public string TransactionTypeCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TransactionAmount { get; set; }
        public string TransactionComment { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
