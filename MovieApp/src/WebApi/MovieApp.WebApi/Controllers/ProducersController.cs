using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Contracts;
using MovieApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private readonly IProducerService producerService;
        public ProducersController(IProducerService producerService)
        {
            this.producerService = producerService;
        }
        [HttpGet("GetAllProducers")]
        public async Task<ActionResult> GetProducersAsync()
        {
            var response = await this.producerService.GetProducersAsync();

            if(response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("CreateProducer")]
        public async Task<ActionResult> CreateProducerAsync([FromBody] ProducerDto producer)
        {
            if (producer == null)
                return BadRequest();

            await this.producerService.CreateProducerAsync(producer);
            return Ok(producer);
        }
    }
}
