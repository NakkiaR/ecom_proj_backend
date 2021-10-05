using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


using Microsoft.EntityFrameworkCore;


namespace eCommerceStarterCode.Controllers
{
    [Route("api/shoppingcart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET api/ShoppingCart/{userId}
        //[HttpGet("{userId}"), Authorize]
        //public IActionResult GetAllCartsForUser(string id)
        //{
        //    var userId = User.FindFirstValue("id");
        //    var userCarts = _context.ShoppingCarts.Include(sc => sc.Product).Where(sc => sc.IdentityUserId == userId).Select(sc => sc.Product);
        //    return Ok(userCarts);

        //}


        //GET api/ShoppingCart/{userId
    //}
    [HttpGet("{userId}"), Authorize]
    public IActionResult GetAllCartsForUser(string id)
    {
        var userId = User.FindFirstValue("id");
        var userCarts = _context.ShoppingCarts.Include(sc => sc.Product).Where(sc => sc.IdentityUserId == userId);
        return Ok(userCarts);
    }



    // POST: api/ShoppingCart/
    [HttpPost]

        public IActionResult Post([FromBody] ShoppingCart value)
        {
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }




        //DELETE api/<ShoppingCartController>/delete/<shoppingcartId>
        [HttpDelete("delete/{id}"), Authorize]
        public void Delete(int id)
        {
            var deleteFromCart = _context.ShoppingCarts.Find(id);
            _context.ShoppingCarts.Remove(deleteFromCart);
            _context.SaveChanges();
        }





        // DELETE api/<ShoppingCartController>/{userId}/delete
        [HttpDelete("{userid}"), Authorize]
        public void Empty(string id)
        {
            var user = User.FindFirstValue("id");
            var userCart = _context.ShoppingCarts.Include(sc => sc.Product).Where(sc => sc.IdentityUserId == user).Select(sc => sc.Product);
            _context.ShoppingCarts.Remove((ShoppingCart)userCart);
            _context.SaveChanges();
        }





    }
}
