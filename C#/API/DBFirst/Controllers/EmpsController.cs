using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecAPI.Models;
using SecAPI.Repository.EmpServices;

namespace SecAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        private readonly IEmpServices _context;

        public EmpsController(IEmpServices context)
        {
            _context = context;
        }

        // GET: api/Emps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emp>>> GetEmps()
        {
            var emp = await _context.GetEmps();
          if (emp == null)
          {
              return NotFound();
          }
            return Ok(emp);
        }

       // GET: api/Emps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emp>> GetEmp(int id)
        {
         
            var emp =  await _context.GetEmp(id);

            if (emp == null)
            {
                return NotFound();
            }

            return Ok(emp);
        }

        // PUT: api/Emps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Emp>> PutEmp(int id, Emp emp)
        {
            return await _context.PutEmp(id, emp);
        }

        // POST: api/Emps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<Emp>>> PostEmp(Emp emp)
        {
            var item=await _context.PostEmp(emp);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // DELETE: api/Emps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmp(int id)
        {
            var emp=await _context.DeleteEmp(id);
            if (emp == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        
    }
}
