using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;

namespace MovieApp.Application.Contracts
{
    public interface IProducerService
    {
        Task<IEnumerable<Producer>> GetProducersAsync();
        
        Task CreateProducerAsync(ProducerDto producer);
    }
}