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
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("product"), Authorize]
        public IActionResult GetCurrentProduct()
        {
            var productId = User.FindFirstValue("id");
            var product = _context.Users.Find(productId);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //// GET api/<ProductController>/5
        //[HttpGet("{Id}")]
        //public IActionResult GetSingleProduct(int id)
        //{
        //    var oneProduct = _context.Products.Where(p => p.Id == id);
        //    return Ok(oneProduct);
        //}

        [HttpPost]

        public IActionResult Post([FromBody] Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        //// DELETE api/<ProductController>/5
        //[HttpDelete]
        //public void Delete(int id)
        //{

        //}
    }
}
