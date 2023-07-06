using APIProj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIProj.Repositories.Services.Movies_Services
{
    public interface IMoviesServices
    {
        Task<IEnumerable<Movie>> GetMovies();
        Task<List<Movie>> PostMovie(Movie movie);
        Task<Movie>? DeleteMovie(int id);
    }
}
