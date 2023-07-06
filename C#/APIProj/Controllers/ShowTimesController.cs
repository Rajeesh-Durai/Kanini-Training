using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIProj.Models;
using APIProj.Repositories.Services.ShowTime_Services;
using Microsoft.AspNetCore.Authorization;

namespace APIProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ShowTimesController : ControllerBase
    {
        private readonly IShowTimeServices _context;

        public ShowTimesController(IShowTimeServices context)
        {
            _context = context;
        }

        // GET: api/ShowTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShowTime>>> GetShowTimes()
        {
            var st = await _context.GetShowTimes();
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }

        // POST: api/ShowTimes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShowTime>> PostShowTime(ShowTime showTime)
        {
            var item = await _context.PostShowTime(showTime);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // DELETE: api/ShowTimes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShowTime(int id)
        {
            var stime = await _context.DeleteShowTime(id);
            if (stime == null)
            {
                return NotFound();
            }


            return NoContent();
        }

       
    }
}
