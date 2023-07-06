using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIProj.Models;
using APIProj.Repositories.Services.Booking_Detail_Services;
using Microsoft.AspNetCore.Authorization;

namespace APIProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookingDetaillsController : ControllerBase
    {
        private readonly IBookingDetails _context;

        public BookingDetaillsController(IBookingDetails context)
        {
            _context = context;
        }

             // GET: api/BookingDetaills
               [HttpGet]
               public async Task<ActionResult<IEnumerable<BookingDetaill>>> GetBookingDetaills()
               {
                    var opt = await _context.GetBookingDetails();
                    if (opt == null)
                    {
                        return NotFound();
                    }
                    return Ok(opt);
                 }

 
    }
}
