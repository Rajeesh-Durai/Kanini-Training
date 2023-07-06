lusing APIProj.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProj.Repositories.Services.Theatre_Services
{
    public class TheatreServices:ITheatreServices
    {
        public ProjectContext _projcontext;
        public TheatreServices(ProjectContext projcontext)
        {
            _projcontext = projcontext;
        }
        public async Task<IEnumerable<Theatre>> GetTheatres()
        {
            return await _projcontext.Theatres.ToListAsync();
        }
        public async Task<List<Theatre>> PostTheatre(Theatre theatre)
        {
            await _projcontext.Theatres.AddAsync(theatre);
            await _projcontext.SaveChangesAsync();
            return await _projcontext.Theatres.ToListAsync();
        }
        public async Task<Theatre>? DeleteTheatre(int id)
        {
            var th = await _projcontext.Theatres.FindAsync(id);
            _projcontext.Theatres.Remove(th);
            await _projcontext.SaveChangesAsync();
            return th;
        }
    }
}
