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
    public class ShowTimesController : ControllerBase
    {
        private readonly ProjectContext _context;

        public ShowTimesController(ProjectContext context)
        {
            _context = context;
        }

        // GET: api/ShowTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShowTime>>> GetShowTimes()
        {
          if (_context.ShowTimes == null)
          {
              return NotFound();
          }
            return await _context.ShowTimes.ToListAsync();
        }

        // GET: api/ShowTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShowTime>> GetShowTime(int id)
        {
          if (_context.ShowTimes == null)
          {
              return NotFound();
          }
            var showTime = await _context.ShowTimes.FindAsync(id);

            if (showTime == null)
            {
                return NotFound();
            }

            return showTime;
        }

        // PUT: api/ShowTimes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShowTime(int id, ShowTime showTime)
        {
            if (id != showTime.ShowId)
            {
                return BadRequest();
            }

            _context.Entry(showTime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShowTimeExists(id))
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

        // POST: api/ShowTimes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShowTime>> PostShowTime(ShowTime showTime)
        {
          if (_context.ShowTimes == null)
          {
              return Problem("Entity set 'ProjectContext.ShowTimes'  is null.");
          }
            _context.ShowTimes.Add(showTime);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShowTimeExists(showTime.ShowId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShowTime", new { id = showTime.ShowId }, showTime);
        }

        // DELETE: api/ShowTimes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShowTime(int id)
        {
            if (_context.ShowTimes == null)
            {
                return NotFound();
            }
            var showTime = await _context.ShowTimes.FindAsync(id);
            if (showTime == null)
            {
                return NotFound();
            }

            _context.ShowTimes.Remove(showTime);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShowTimeExists(int id)
        {
            return (_context.ShowTimes?.Any(e => e.ShowId == id)).GetValueOrDefault();
        }
    }
}
