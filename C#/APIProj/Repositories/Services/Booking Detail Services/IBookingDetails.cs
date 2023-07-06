using APIProj.Models;

namespace APIProj.Repositories.Services.Booking_Detail_Services
{
    public interface IBookingDetails
    {
        Task<IEnumerable<BookingDetaill>> GetBookingDetails();
    }
}
