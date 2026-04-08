using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookstoreManagement_CodeFirst.Models;

namespace BookstoreManagement_CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldsController : ControllerBase
    {
        private readonly FootballFieldDbContext _context;

        public FieldsController(FootballFieldDbContext context)
        {
            _context = context;
        }

        // GET: api/Fields
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Field>>> GetFields()
        {
            return await _context.Fields.Include(f => f.FieldType).ToListAsync();
        }
    }
}