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
        private readonly IActorsRepository actorsRepository;
        private readonly IMapper mapper;
        public MoviesService(IMoviesRepository movieRepository,IActorsRepository actorsRepository, IMapper mapper)
        {
            this.moviesRepository = movieRepository;
            this.actorsRepository = actorsRepository;
            this.mapper = mapper;   
        }

        public async Task CreateMovieAsync(MovieDto movie)
        {
            var actors  = this.actorsRepository.GetActors(movie.ActorIds);
            var movieEntity = this.mapper.Map<Movie>(movie);
            movieEntity.Actors = actors.Result;
            await this.moviesRepository.CreateMovieAsync(movieEntity).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            var result = await this.moviesRepository.GetMoviesAsync();
            return result;
        }

        public async Task UpdateMovieAsync(int id, MovieDto movieDto)
        {
                var movieEntity = mapper.Map<Movie>(movieDto);
                await this.moviesRepository.UpdateMovieAsync(id, movieEntity);
        }
    }
}
