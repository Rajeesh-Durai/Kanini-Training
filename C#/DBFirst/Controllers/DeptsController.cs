using Microsoft.AspNetCore.Mvc;
using SecAPI.Models;
using SecAPI.Repository.DeptServices;

namespace SecAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptsController : ControllerBase
    {
        private readonly IDeptServices _context;

        public DeptsController(IDeptServices context)
        {
            _context = context;
        }

       // GET: api/Depts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dept>>> GetDepts()
        {
            var dept = await _context.GetDepts();
          if (dept == null)
          {
              return NotFound();
          }
            return Ok(dept);
        }

        // GET: api/Depts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dept>> GetDept(int id)
        {
            var dept = _context.GetDept(id);
          if (dept== null)
          {
              return NotFound();
          }

            return Ok(dept);
        }

        // PUT: api/Depts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Dept>> PutDept(int id, Dept dept)
        {
            return Ok( await _context.PutDept(id, dept));
        }

      // POST: api/Depts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<Dept>>> PostDept(Dept dept)
        {
            var item = await _context.PostDept(dept);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // DELETE: api/Depts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDept(int id)
        {
           var dept=await _context.DeleteDept(id);
            if (dept == null)
            {
                return NotFound();
            } 
            return NoContent();
        }

        
    }
}
