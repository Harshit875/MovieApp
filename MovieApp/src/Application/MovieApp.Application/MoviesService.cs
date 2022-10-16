using AutoMapper;
using MovieApp.Infrastructure.Data.Contracts;
using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application
{
    public class MoviesService: IMoviesService
    {
        private readonly IMoviesRepository moviesRepository;
        private readonly IMapper mapper;
        public MoviesService(IMoviesRepository movieRepository, IMapper mapper)
        {
            this.moviesRepository = movieRepository;
            this.mapper = mapper;   
        }

        public async Task CreateMoviesAsync(MovieDto movie)
        {
            var movieEntity = this.mapper.Map<Movie>(movie);
            await this.moviesRepository.CreateMoviesAsync(movieEntity).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            var result = await this.moviesRepository.GetMoviesAsync();
            return result;
        }

        public async Task UpdateMoviesAsync(int id, MovieDto movieDto)
        {
                var movieEntity = mapper.Map<Movie>(movieDto);
                await this.moviesRepository.UpdateMoviesAsync(id, movieEntity);
        }
    }
}
