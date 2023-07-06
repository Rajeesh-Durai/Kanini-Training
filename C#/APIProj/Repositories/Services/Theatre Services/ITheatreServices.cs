using APIProj.Models;

namespace APIProj.Repositories.Services.Theatre_Services
{
    public interface ITheatreServices
    {
        Task<IEnumerable<Theatre>> GetTheatres();
        Task<List<Theatre>> PostTheatre(Theatre theatre);
        Task<Theatre>? DeleteTheatre(int id);

    }
}
