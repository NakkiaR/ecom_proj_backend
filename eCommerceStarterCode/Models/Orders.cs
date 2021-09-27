using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderAmount { get; set; }
    }
}
