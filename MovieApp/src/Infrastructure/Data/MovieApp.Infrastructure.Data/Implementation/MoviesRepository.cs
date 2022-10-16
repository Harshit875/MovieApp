using Microsoft.EntityFrameworkCore;
using MovieApp.Infrastructure.Data.Configurations;
using MovieApp.Infrastructure.Data.Contracts;
using MovieApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Data.Implementation
{
    public class MoviesRepository : IMoviesRepository
    {
        private MovieAppDbContext context;
        public MoviesRepository(MovieAppDbContext context) 
        {
            this.context = context;
        }

        public async Task CreateMovieAsync(Movie movie)
        {
            await this.context.Movies.AddAsync(movie).ConfigureAwait(false);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            var result = await this.context.Movies.Include(x => x.Actors).Include(p => p.Producer).ToListAsync().ConfigureAwait(false);
            return result;
        }
        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var result = await this.context.Movies.FindAsync(id).ConfigureAwait(false);
            return result;
        }

        public async Task UpdateMovieAsync(int id, Movie movie)
        {
            var existingMovie = await this.context.Movies.FindAsync(id).ConfigureAwait(false);

            if(existingMovie!= null)
            {
                existingMovie.Producer = movie.Producer;
                existingMovie.Poster = movie.Poster;
                existingMovie.Actors = movie.Actors;
                existingMovie.Plot= movie.Plot;
                existingMovie.Poster= movie.Poster; 
                existingMovie.ReleaseDate= movie.ReleaseDate;
                existingMovie.Title= movie.Title;
                await this.context.SaveChangesAsync();
            }
        }

    }
}
