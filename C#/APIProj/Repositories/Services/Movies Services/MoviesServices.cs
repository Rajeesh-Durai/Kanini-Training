using APIProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIProj.Repositories.Services.Movies_Services
{
    public class MoviesServices : IMoviesServices
    {
        private readonly ProjectContext _projcontext;

        public MoviesServices(ProjectContext projcontext)
        {
            _projcontext = projcontext;
        }
        public async Task<IEnumerable<Movie>> GetMovies()
        {
              return await _projcontext.Movies.ToListAsync();           
        }
        public async Task<List<Movie>> PostMovie(Movie movie)
        {
            await _projcontext.Movies.AddAsync(movie);
            await _projcontext.SaveChangesAsync();
            return await _projcontext.Movies.ToListAsync();
        }
        public async Task<Movie>? DeleteMovie(int id)
        {
            var del = await _projcontext.Movies.FindAsync(id);
            _projcontext.Movies.Remove(del);
            await _projcontext.SaveChangesAsync();
            return del;
        }
    }
}
