using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Contracts;
using MovieApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IActorService actorService;
        public ActorsController(IActorService actorService)
        {
            this.actorService = actorService;
        }
        [HttpGet("GetAllActors")]
        public async Task<ActionResult> GetActorsAsync()
        {
            var response = await this.actorService.GetActorsAsync();

            if(response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("CreateActor")]
        public async Task<ActionResult> CreateActorAsync([FromBody] ActorDto actor)
        {
            if (actor == null)
                return BadRequest();

            await this.actorService.CreateActorAsync(actor);
            return Ok(actor);
        }
    }
}
