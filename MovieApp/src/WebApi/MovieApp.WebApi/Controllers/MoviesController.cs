using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Contracts;
using MovieApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService moviesService;

        public MoviesController(IMovieService moviesService)
        {
            this.moviesService = moviesService;
        }

        [HttpGet("GetAllMovies")]
        public async Task<ActionResult> GetMoviesAsync()
        {
            var response = await this.moviesService.GetMoviesAsync();
            if(response == null)
                return NotFound();

            return this.Ok(response);
        }

        [HttpPost("CreateMovie")]
        public async Task<ActionResult> CreateMovieAsync([FromBody] MovieDto movie)
        {
            if(movie== null)
            {
                return BadRequest("MovieDto object is null");
            }
            await this.moviesService.CreateMovieAsync(movie);
            return this.Ok(movie);
        }

        [HttpPut("UpdateMovie/{id}")]
        public async Task<ActionResult> UpdateMoviesAsync(int id, [FromBody] MovieDto movie)
        {
            if (movie == null)
            {
                return BadRequest("MovieDto object is null");
            }
            await this.moviesService.UpdateMovieAsync(id, movie);
            return this.Ok(movie);
        }
    }
}
