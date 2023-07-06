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
    public class TheatresController : ControllerBase
    {
        private readonly ProjectContext _context;

        public TheatresController(ProjectContext context)
        {
            _context = context;
        }

        // GET: api/Theatres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Theatre>>> GetTheatres()
        {
          if (_context.Theatres == null)
          {
              return NotFound();
          }
            return await _context.Theatres.ToListAsync();
        }

        // GET: api/Theatres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Theatre>> GetTheatre(int id)
        {
          if (_context.Theatres == null)
          {
              return NotFound();
          }
            var theatre = await _context.Theatres.FindAsync(id);

            if (theatre == null)
            {
                return NotFound();
            }

            return theatre;
        }

        // PUT: api/Theatres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheatre(int id, Theatre theatre)
        {
            if (id != theatre.TheatreId)
            {
                return BadRequest();
            }

            _context.Entry(theatre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TheatreExists(id))
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

        // POST: api/Theatres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Theatre>> PostTheatre(Theatre theatre)
        {
          if (_context.Theatres == null)
          {
              return Problem("Entity set 'ProjectContext.Theatres'  is null.");
          }
            _context.Theatres.Add(theatre);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TheatreExists(theatre.TheatreId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTheatre", new { id = theatre.TheatreId }, theatre);
        }

        // DELETE: api/Theatres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTheatre(int id)
        {
            if (_context.Theatres == null)
            {
                return NotFound();
            }
            var theatre = await _context.Theatres.FindAsync(id);
            if (theatre == null)
            {
                return NotFound();
            }

            _context.Theatres.Remove(theatre);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TheatreExists(int id)
        {
            return (_context.Theatres?.Any(e => e.TheatreId == id)).GetValueOrDefault();
        }
    }
}
