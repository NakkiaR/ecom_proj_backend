using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
       
        
        public DateTime ShipmentArrivalDate { get; set; }
        public DateTime ShipmentDate { get; set; }

        [ForeignKey("Order")]
        public string OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}