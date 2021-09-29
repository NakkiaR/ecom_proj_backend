﻿//using eCommerceStarterCode.Data;
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
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public ProductController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet("Product"), Authorize]
//        public IActionResult GetCurrentProduct()
//        {
//            var productId = User.FindFirstValue("Id");
//            var product = _context.Users.Find(productId);
//            if (product == null)
//            {
//                return NotFound();
//            }
//            return Ok(product);
//        }

//        [HttpPost]

//        public IActionResult Post([FromBody] Product value)
//        {
//            _context.Products.Add(value);
//            _context.SaveChanges();
//            return StatusCode(201, value);
//        }
//    }
//}