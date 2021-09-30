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
    [Route("api/review")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }



        //this will require the reviews to only be seen by authorized ppl

        //[HttpGet("review"), Authorize]
        //public IActionResult GetCurrentReview()
        //{
        //    var userId = User.FindFirstValue("id");
        //    var review = _context.Users.Find(userId);
        //    if (review == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(review);
        //}

        [HttpPost]

        public IActionResult Post([FromBody] Review value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }



        // DELETE api/<ProductController>/5
        [HttpDelete]
        public void Delete(int id)
        {

        }


        // GET: api/<ReviewsController>
        [HttpGet]
        public IActionResult GetAllReviews()
        {
            var reviews = _context.Reviews;
            return Ok(reviews);
        }



        //should this be category ID or prod. ID? Category right? 

        //[HttpGet("rating{productId}")]
        //public IActionResult GetReviews(int productId)
        //{
        //    var totalRating = _context.Reviews.Where(r => r.ProductId == productId).Select(a => (decimal)a.Rating).Sum();
        //    var numberOfReviews = _context.Reviews.Where(r => r.ProductId == productId).Count();
        //    var ratingsAverage = (decimal)0;
        //    if (totalRating == 0)
        //    {
        //        ratingsAverage = 0;
        //    }
        //    else if (numberOfReviews > 0)
        //    {
        //        ratingsAverage = totalRating / numberOfReviews;
        //    }
        //    return Ok(ratingsAverage);
        //}
    }
}
