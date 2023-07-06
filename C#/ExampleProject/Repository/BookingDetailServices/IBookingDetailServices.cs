using ExampleProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleProject.Repository.BookingDetailServices
{
    public interface IBookingDetailServices
    {
         Task<BookingDetails> GetbookingDetails();
        Task<BookingDetails>? GetBookingDetails(int id);
        Task<List<roughCls>> PostBookingDetails(BookingDetails bookingDetails);

    }
}
