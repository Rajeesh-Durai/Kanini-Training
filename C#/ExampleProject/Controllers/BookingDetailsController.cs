using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExampleProject.Data;
using ExampleProject.Models;
using ExampleProject.Repository.BookingDetailServices;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.Linq.Expressions;

namespace ExampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingDetailsController : ControllerBase
    {
        private readonly IBookingDetailServices _context;

        public BookingDetailsController(IBookingDetailServices context)
        {
            _context = context;
        }

        // GET: api/BookingDetails
        [HttpGet]
        public async Task<ActionResult<object>> GetbookingDetails()
        {
            var opt = await _context.GetbookingDetails();
          if (opt == null)
          {
              return NotFound();
          }
            return Ok(opt);
        }

       // GET: api/BookingDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingDetails>>? GetBookingDetails(int id)
        {
            try {
                var opt = await _context.GetBookingDetails(id);
                return Ok(opt);
            }


            catch(ArithmeticException ex)
            {
                return NotFound(ex.Message);
            }



        }

        /*      // PUT: api/BookingDetails/5
             // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
             [HttpPut("{id}")]
             public async Task<IActionResult> PutBookingDetails(int id, BookingDetails bookingDetails)
             {
                 if (id != bookingDetails.BookingId)
                 {
                     return BadRequest();
                 }

                 _context.Entry(bookingDetails).State = EntityState.Modified;

                 try
                 {
                     await _context.SaveChangesAsync();
                 }
                 catch (DbUpdateConcurrencyException)
                 {
                     if (!BookingDetailsExists(id))
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
        */
             // POST: api/BookingDetails
             // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
             [HttpPost]
             public async Task<ActionResult<List<roughCls>>> PostBookingDetails(BookingDetails bookingDetails)
             {
                    try{
                        var opt = await _context.PostBookingDetails(bookingDetails);
                        return Ok(opt);
                        }
                    catch(ArithmeticException ex)
                        {
                        return NotFound(ex.Message);
                        }
             }
        /*
             // DELETE: api/BookingDetails/5
             [HttpDelete("{id}")]
             public async Task<IActionResult> DeleteBookingDetails(int id)
             {
                 if (_context.bookingDetails == null)
                 {
                     return NotFound();
                 }
                 var bookingDetails = await _context.bookingDetails.FindAsync(id);
                 if (bookingDetails == null)
                 {
                     return NotFound();
                 }

                 _context.bookingDetails.Remove(bookingDetails);
                 await _context.SaveChangesAsync();

                 return NoContent();
             }

             private bool BookingDetailsExists(int id)
             {
                 return (_context.bookingDetails?.Any(e => e.BookingId == id)).GetValueOrDefault();
             }*/
    }
}
