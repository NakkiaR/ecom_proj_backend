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

       

        [HttpGet]
        public IActionResult Get()
        {
            var category = _context.Categories;
            return Ok(category);
        }


        [HttpPost]

        public IActionResult Post([FromBody] Category value)
        {
            _context.Categories.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
