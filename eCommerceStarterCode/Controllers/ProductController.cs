﻿using eCommerceStarterCode.Data;
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


        ////GET: api/<productcontroller>/<productID>
        //[HttpGet("product/{ProductId}")]
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


        //not returning any content. There's likely a problem with the endpoint. Not entirely sure that we even need it
        [HttpGet("{ProductId}/product")]

        public IActionResult GetProdById(string prodId)
        {
            var product = _context.Products.Find(prodId);
            return Ok(product);
        }



        // GET api/<ProductController>/<catergoryid>
        //Filters products by category. 
        [HttpGet("{CategoryId}")]
        public IActionResult GetProductByCategory(int categoryId)
        {
            var oneProduct = _context.Products.Where(c => c.CategoryId == categoryId);
            return Ok(oneProduct);
        }




        //api/<productcontroller>
        [HttpPost, Authorize]

        public IActionResult Post([FromBody] Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        

        //Deletes a product from the table. Should be done after the product is checked out. 
        // DELETE api/<ProductController>/<prodID>
        [HttpDelete("{ProductId}"), Authorize]

        public void Del(string ProductId)
        {
            var prod = _context.Products.Find(ProductId);
            _context.Products.Remove(prod);
            _context.SaveChanges();
        }




        private void ProblemOne()
        {
            // Write a LINQ query that returns the number of users in the Users table.
            // HINT: .ToList().Count
            var users = _context.Users;
            var numberOfUsers = users.ToList().Sort();
            Console.WriteLine(numberOfUsers);

        }


        public void SortProductsByCategory ()
        {
            var catSort = _context.Products.OrderBy(p => p.CategoryId);

            foreach (Product prod in catSort)
            {
                Console.WriteLine(prod.Name);
            }




        }


    }
}
