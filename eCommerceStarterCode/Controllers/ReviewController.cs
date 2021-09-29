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
//    public class ReviewController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public ReviewController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet("Review"), Authorize]
//        public IActionResult GetCurrentReview()
//        {
//            var reviewId = User.FindFirstValue("Id");
//            var review = _context.Users.Find(reviewId);
//            if (review == null)
//            {
//                return NotFound();
//            }
//            return Ok(review);
//        }

//        [HttpPost]

//        public IActionResult Post([FromBody] Review value)
//        {
//            _context.Reviews.Add(value);
//            _context.SaveChanges();
//            return StatusCode(201, value);
//        }
//    }
//}
