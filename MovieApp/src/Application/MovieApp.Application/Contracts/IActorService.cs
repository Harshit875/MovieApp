using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;

namespace MovieApp.Application.Contracts
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetActorsAsync();
        
        Task CreateActorAsync(ActorDto actor);
    }
}