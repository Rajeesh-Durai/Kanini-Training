using APIProj.Models;

namespace APIProj.Repositories.Services.ShowTime_Services
{
    public interface IShowTimeServices
    {
        Task<IEnumerable<ShowTime>> GetShowTimes();
        Task<List<ShowTime>> PostShowTime(ShowTime showTime);
        Task<ShowTime>? DeleteShowTime(int id);
    }
}
