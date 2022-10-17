using MovieApp.Infrastructure.Data.Entities;

namespace MovieApp.Infrastructure.Data.Contracts
{
    public interface IActorRepository
    { 
        Task<IEnumerable<Actor>> GetActorsAsync();
        Task<ICollection<Actor>> GetActorsByActorIdsAsync(ICollection<int> ActorIds);
        Task CreateActorAsync(Actor movie);
    }
}