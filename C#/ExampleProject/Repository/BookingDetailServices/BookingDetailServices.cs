using ExampleProject.Data;
using ExampleProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExampleProject.Repository.BookingDetailServices
{
    public class BookingDetailServices
    {
       private readonly  MovieContext _movieContext;
        public BookingDetailServices(MovieContext movieContext) 
        {
            _movieContext = movieContext;        
        }
        public async Task<object> GetbookingDetails()
        {
            var max=  _movieContext.bookingDetails.Max(x=>x.UserId);
            return max;
        }
        public async Task<object>? GetBookingDetails(int id)
        {
            var bookingDetails = await _movieContext.bookingDetails.FirstOrDefaultAsync(x => x.UserId == id);

            if (bookingDetails == null)
            {
                throw new ArithmeticException("Not available");

            }
            return bookingDetails.BookingDate;
        }
        public async Task<List<roughCls>> PostBookingDetails(BookingDetails bookingDetails)
        {
            var join = await (from b in _movieContext.bookingDetails join u in _movieContext.logins on b.UserId equals u.UserId
                              select new roughCls
                              {
                                  UserId= b.UserId,
                                  UserName=u.UserName,
                                  BookingDate= b.BookingDate

                              }).ToListAsync();
            return join;

            
                          
          
        }

}
}
