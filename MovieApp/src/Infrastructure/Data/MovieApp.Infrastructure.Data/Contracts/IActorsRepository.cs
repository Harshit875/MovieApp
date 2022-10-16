using MovieApp.Infrastructure.Data.Entities;

namespace MovieApp.Infrastructure.Data.Contracts
{
    public interface IActorsRepository
    {
        Task<ICollection<Actor>> GetActors(ICollection<int> ActorIds);
        Task CreateActorAsync(Actor movie);
    }
}