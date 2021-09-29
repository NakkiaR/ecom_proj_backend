//using eCommerceStarterCode.Data;
//using eCommerceStarterCode.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;

//namespace eCommerceStarterCode.Controllers
//{
//    [Route("api/examples")]
//    [ApiController]
//    public class OrderController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public OrderController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet("Order"), Authorize]
//        public IActionResult GetCurrentOrder()
//        {
//            var orderId = User.FindFirstValue("Id");
//            var order = _context.Users.Find(orderId);
//            if (order == null)
//            {
//                return NotFound();
//            }
//            return Ok(order);
//        }

//        [HttpPost]

//        public IActionResult Post([FromBody] Order value)
//        {
//            _context.Orders.Add(value);
//            _context.SaveChanges();
//            return StatusCode(201, value);
//        }
//    }
//}
