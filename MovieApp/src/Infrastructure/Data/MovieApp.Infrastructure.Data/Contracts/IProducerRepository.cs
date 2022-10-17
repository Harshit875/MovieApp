using MovieApp.Infrastructure.Data.Entities;

namespace MovieApp.Infrastructure.Data.Contracts
{
    public interface IProducerRepository
    { 
        Task<IEnumerable<Producer>> GetProducersAsync();
        Task CreateProducerAsync(Producer movie);
    }
}