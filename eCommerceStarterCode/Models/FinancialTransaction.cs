using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class FinancialTransaction
    {
        public int FinancialTransactionId { get; set; }
        
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
