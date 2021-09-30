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


        //Get all products
        //GET: api/<productcontroller>
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products;
            return Ok(products);
        }



        //[HttpGet("product"), Authorize]
        //public IActionResult GetCurrentProduct()
        //{
        //    var productId = User.FindFirstValue("id");
        //    var product = _context.Users.Find(productId);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}



        // GET api/<ProductController>/<catergoryid>
        [HttpGet("{CategoryId}")]
        public IActionResult GetProductByCategory(int categoryId)
        {
            var oneProduct = _context.Products.Where(c => c.CategoryId == categoryId);
            return Ok(oneProduct);
        }


        //api/<productcontroller>
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
