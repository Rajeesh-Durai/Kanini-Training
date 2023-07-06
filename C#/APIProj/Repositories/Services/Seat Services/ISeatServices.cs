using APIProj.Models;

namespace APIProj.Repositories.Services.Seat_Services
{
    public interface ISeatServices
    {
        Task<IEnumerable<Seat>> GetSeats();

    }
}
