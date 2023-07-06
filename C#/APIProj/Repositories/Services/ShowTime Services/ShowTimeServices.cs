using APIProj.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProj.Repositories.Services.ShowTime_Services
{
    public class ShowTimeServices:IShowTimeServices
    {
        public ProjectContext _projcontext;
        public ShowTimeServices(ProjectContext projcontext)
        {
            _projcontext = projcontext;
        }
        public async Task<IEnumerable<ShowTime>> GetShowTimes()
        {
            return await _projcontext.ShowTimes.ToListAsync();
        }
        public async Task<List<ShowTime>> PostShowTime(ShowTime showTime)
        {
            var item = _projcontext.ShowTimes.AddAsync(showTime);
            await _projcontext.SaveChangesAsync();
            return await _projcontext.ShowTimes.ToListAsync();
        }
        public async Task<ShowTime> DeleteShowTime(int id)
        {
            var st = await _projcontext.ShowTimes.FindAsync(id);
            _projcontext.ShowTimes.Remove(st);
            await _projcontext.SaveChangesAsync();
            return st;
        }
    }
}
