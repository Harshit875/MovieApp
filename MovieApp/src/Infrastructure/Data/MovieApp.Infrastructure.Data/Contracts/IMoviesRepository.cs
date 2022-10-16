using MovieApp.Infrastructure.Data.Entities;

namespace MovieApp.Infrastructure.Data.Contracts
{
    public interface IMoviesRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task CreateMovieAsync(Movie movie);
        Task UpdateMovieAsync(int id, Movie movie);
    }
}