using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
       
        
        public DateTime ShipmentArrivalDate { get; set; }
        public DateTime ShipmentDate { get; set; }

        
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

    }
}