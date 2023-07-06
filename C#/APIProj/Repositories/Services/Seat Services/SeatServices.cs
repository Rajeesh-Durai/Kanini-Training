using APIProj.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProj.Repositories.Services.Seat_Services
{
    public class SeatServices:ISeatServices
    {
        public ProjectContext _projcontext;
        public SeatServices(ProjectContext projcontext)
        {
            _projcontext = projcontext;
        }
        public async Task<IEnumerable<Seat>> GetSeats()
        {
            return await _projcontext.Seats.ToListAsync();
        }
    }
}
