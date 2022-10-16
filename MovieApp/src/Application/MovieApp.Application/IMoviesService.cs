using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;

namespace MovieApp.Application
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();

        Task CreateMoviesAsync(MovieDto movie);

        Task UpdateMoviesAsync(int id, MovieDto movie);
    }
}