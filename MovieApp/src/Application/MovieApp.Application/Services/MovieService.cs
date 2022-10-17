using AutoMapper;
using MovieApp.Application.Contracts;
using MovieApp.Infrastructure.Data.Contracts;
using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository moviesRepository;
        private readonly IActorRepository actorsRepository;
        private readonly IMapper mapper;
        public MovieService(IMovieRepository movieRepository, IActorRepository actorsRepository, IMapper mapper)
        {
            moviesRepository = movieRepository;
            this.actorsRepository = actorsRepository;
            this.mapper = mapper;
        }

        public async Task CreateMovieAsync(MovieDto movie)
        {
            var actors = actorsRepository.GetActorsByActorIdsAsync(movie.ActorIds);
            var movieEntity = mapper.Map<Movie>(movie);
            movieEntity.Actors = actors.Result;
            await moviesRepository.CreateMovieAsync(movieEntity).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            var result = await moviesRepository.GetMoviesAsync();
            return result;
        }

        public async Task UpdateMovieAsync(int id, MovieDto movieDto)
        {
            var actors = actorsRepository.GetActorsByActorIdsAsync(movieDto.ActorIds);
            var movieEntity = mapper.Map<Movie>(movieDto);
            movieEntity.Actors = actors.Result;
            await moviesRepository.UpdateMovieAsync(id, movieEntity);
        }
    }
}
