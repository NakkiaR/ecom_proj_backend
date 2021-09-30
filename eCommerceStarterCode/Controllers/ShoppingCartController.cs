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
    [Route("api/shoppingcart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }
        // /api/shoppingcart/all

        [HttpGet("all"), Authorize]
        public IActionResult GetShoppingCartForUser()
        {
            var userId = User.FindFirstValue("id");
            var shoppingCarts = _context.ShoppingCarts.Where(sc => sc.IdentityUserId == userId);
            if (shoppingCarts == null)
            {
                return NotFound();
            }
            return Ok(shoppingCarts);
        }
        // /api/shoppingcart

        [HttpPost]

        public IActionResult Post([FromBody] ShoppingCart value)
        {
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }


        // /api/shoppingcart/4
        [HttpDelete("{productId}")]
        public IActionResult Delete([FromBody] ShoppingCart value)
        {
            _context.ShoppingCarts.Remove(value);
            _context.SaveChanges();
            return StatusCode(201);
        }


        //private void ProblemSeventeen()
        //{
        //    // Change the role of the user we created to "Employee"
        //    // HINT: You need to delete the existing role relationship and then create a new UserRole object and add it to the UserRoles table
        //    // See problem eighteen as an example of removing a role relationship
        //    var userRole = _context.UserRoles.Where(ur => ur.User.Email == "mike@gmail.com").SingleOrDefault();
        //    _context.UserRoles.Remove(userRole);
        //    UserRole newUserRole = new UserRole()
        //    {
        //        UserId = _context.Users.Where(u => u.Email == "mike@gmail.com").Select(u => u.Id).SingleOrDefault(),
        //        RoleId = _context.Roles.Where(r => r.RoleName == "Employee").Select(r => r.Id).SingleOrDefault()
        //    };
        //    _context.UserRoles.Add(newUserRole);
        //    _context.SaveChanges();
        //}
    }
}
