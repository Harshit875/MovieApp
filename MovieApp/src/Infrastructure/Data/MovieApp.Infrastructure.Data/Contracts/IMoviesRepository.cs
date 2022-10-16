using MovieApp.Infrastructure.Data.Entities;

namespace MovieApp.Infrastructure.Data.Contracts
{
    public interface IMoviesRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task CreateMoviesAsync(Movie movie);
        Task UpdateMoviesAsync(int id, Movie movie);
    }
}