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
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet("category"), Authorize]
        //public IActionResult GetCurrentCategory()
        //{
        //    var categoryId = User.FindFirstValue("id");
        //    var category = _context.Users.Find(categoryId);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(category);
        //}

        [HttpGet]
        public IActionResult Get()
        {
            var category = _context.Categories;
            return Ok(category);
        }


        //private void ProblemFourteen()
        //{
        //    // Add the product you create to the user we created in the ShoppingCart junction table using LINQ.
        //    var userId = _context.Users.Where(u => u.Email == "david@gmail.com").Select(u => u.Id).SingleOrDefault();
        //    var productId = _context.Products.Where(p => p.Id == 8).Select(p => p.Id).SingleOrDefault();
        //    ShoppingCart newProduct = new ShoppingCart()
        //    {
        //        UserId = userId,
        //        ProductId = productId,
        //        Quantity = 1,
        //    };
        //    _context.ShoppingCarts.Add(newProduct);
        //    _context.SaveChanges();
        //}



        [HttpPost]

        public IActionResult Post([FromBody] Category value)
        {
            _context.Categories.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
