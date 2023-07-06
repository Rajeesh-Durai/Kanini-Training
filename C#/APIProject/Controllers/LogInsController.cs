using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIProject.Models;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInsController : ControllerBase
    {
        private readonly ProjectContext _context;

        public LogInsController(ProjectContext context)
        {
            _context = context;
        }

        // GET: api/LogIns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LogIn>>> GetLogIns()
        {
          if (_context.LogIns == null)
          {
              return NotFound();
          }
            return await _context.LogIns.ToListAsync();
        }

        // GET: api/LogIns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LogIn>> GetLogIn(int id)
        {
          if (_context.LogIns == null)
          {
              return NotFound();
          }
            var logIn = await _context.LogIns.FindAsync(id);

            if (logIn == null)
            {
                return NotFound();
            }

            return logIn;
        }

        // PUT: api/LogIns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogIn(int id, LogIn logIn)
        {
            if (id != logIn.LoginId)
            {
                return BadRequest();
            }

            _context.Entry(logIn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogInExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LogIns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LogIn>> PostLogIn(LogIn logIn)
        {
          if (_context.LogIns == null)
          {
              return Problem("Entity set 'ProjectContext.LogIns'  is null.");
          }
            _context.LogIns.Add(logIn);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LogInExists(logIn.LoginId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLogIn", new { id = logIn.LoginId }, logIn);
        }

        // DELETE: api/LogIns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogIn(int id)
        {
            if (_context.LogIns == null)
            {
                return NotFound();
            }
            var logIn = await _context.LogIns.FindAsync(id);
            if (logIn == null)
            {
                return NotFound();
            }

            _context.LogIns.Remove(logIn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LogInExists(int id)
        {
            return (_context.LogIns?.Any(e => e.LoginId == id)).GetValueOrDefault();
        }
    }
}
