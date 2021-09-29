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
    public class PaymentMethodController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PaymentMethodController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("PaymentMethod"), Authorize]
        public IActionResult GetCurrentPaymentMethod()
        {
            var paymentMethodId = User.FindFirstValue("Id");
            var paymentMethod = _context.Users.Find(paymentMethodId);
            if (paymentMethod == null)
            {
                return NotFound();
            }
            return Ok(paymentMethod);
        }

        [HttpPost]

        public IActionResult Post([FromBody] PaymentMethod value)
        {
            _context.PaymentMethods.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
