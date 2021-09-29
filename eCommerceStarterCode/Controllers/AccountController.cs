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
    [Route("api/examples")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Account"), Authorize]
        public IActionResult GetCurrentAccount()
        {
            var accountId = User.FindFirstValue("Id");
            var account = _context.Users.Find(accountId);
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Account value)
        {
            _context.Accounts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
