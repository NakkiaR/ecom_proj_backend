using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/examples")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShipmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Shipment"), Authorize]
        public IActionResult GetCurrentShipment()
        {
            var shipmentId = User.FindFirstValue("Id");
            var shipment = _context.Users.Find(shipmentId);
            if (shipment == null)
            {
                return NotFound();
            }
            return Ok(shipment);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Shipment value)
        {
            _context.Shipments.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
