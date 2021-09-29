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
    [Route("api/financialtransaction")]
    [ApiController]
    public class FinacialTransactionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FinacialTransactionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("finacialtransaction"), Authorize]
        public IActionResult GetCurrentFinancialTransaction()
        {
            var financialTransactionId = User.FindFirstValue("id");
            var financialTransaction = _context.Users.Find(financialTransactionId);
            if (financialTransaction == null)
            {
                return NotFound();
            }
            return Ok(financialTransaction);
        }

        [HttpPost]

        public IActionResult Post([FromBody] FinancialTransaction value)
        {
            _context.FinancialTransactions.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
