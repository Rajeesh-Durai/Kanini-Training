using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIProj.Models;
using APIProj.Repositories.Services.Seat_Services;
using Microsoft.AspNetCore.Authorization;

namespace APIProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SeatsController : ControllerBase
    {
        private readonly ISeatServices _context;

        public SeatsController(ISeatServices context)
        {
            _context = context;
        }

       // GET: api/Seats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seat>>> GetSeats()
        {

            var t_seat = await _context.GetSeats();
            if (t_seat == null)
            {
                return NotFound();
            }
            return Ok(t_seat);
        }

    }
}
