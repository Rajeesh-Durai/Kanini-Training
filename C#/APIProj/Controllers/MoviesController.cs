using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIProj.Models;
using APIProj.Repositories.Services.Movies_Services;
using Microsoft.AspNetCore.Authorization;

namespace APIProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesServices _context;

        public MoviesController(IMoviesServices context)
        {
            _context = context;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            var opt =await _context.GetMovies();
          if (opt == null)
          {
              return NotFound();
          }
            return Ok(opt);
        }

        // POST: api/Movies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            var item = await _context.PostMovie(movie);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var mov = await _context.DeleteMovie(id);
            if (mov == null)
            {
                return NotFound();
            }


            return NoContent();
        }

    }
}
