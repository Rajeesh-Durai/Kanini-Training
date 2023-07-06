using APIProj.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProj.Repositories.Services.Booking_Detail_Services
{
    public class BookingDetails:IBookingDetails
    {
        private readonly ProjectContext _projcontext;

        public BookingDetails(ProjectContext projcontext)
        {
            _projcontext = projcontext;
        }
        public async Task<IEnumerable<BookingDetaill>> GetBookingDetails()
        {
            return await _projcontext.BookingDetaills.ToListAsync();
        }
    }
}
