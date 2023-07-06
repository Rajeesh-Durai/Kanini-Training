using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIProj.Models;
using Microsoft.AspNetCore.Authorization;
using APIProj.Repositories.Services.Theatre_Services;

namespace APIProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TheatresController : ControllerBase
    {
        private readonly ITheatreServices _context;

        public TheatresController(ITheatreServices context)
        {
            _context = context;
        }

        // GET: api/Theatres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Theatre>>> GetTheatres()
        {
            var th = await _context.GetTheatres();
            if (th == null)
            {
                return NotFound();
            }
            return Ok(th);
        }

    

        // POST: api/Theatres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Theatre>> PostTheatre(Theatre theatre)
        {
            var item = await _context.PostTheatre(theatre);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
       
        }

        // DELETE: api/Theatres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTheatre(int id)
        {
            var theat = await _context.DeleteTheatre(id);
            if (theat == null)
            {
                return NotFound();
            }

            return NoContent();
        }

       
    }
}
