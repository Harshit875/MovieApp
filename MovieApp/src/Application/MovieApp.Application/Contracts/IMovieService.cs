using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;

namespace MovieApp.Application.Contracts
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task CreateMovieAsync(MovieDto movie);
        Task UpdateMovieAsync(int id, MovieDto movie);
    }
}