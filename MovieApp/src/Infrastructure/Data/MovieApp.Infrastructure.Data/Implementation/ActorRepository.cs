using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MovieApp.Infrastructure.Data.Contracts;
using MovieApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Data.Implementation
{
    public class ActorRepository : IActorRepository
    {
        private MovieAppDbContext context;

        public ActorRepository(MovieAppDbContext context)
        {
            this.context = context; 
        }

        public async Task CreateActorAsync(Actor actor)
        {
            await this.context.AddAsync(actor);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetActorsAsync()
        {
            return await this.context.Actors.ToListAsync().ConfigureAwait(false);
        }

        public async Task<ICollection<Actor>> GetActorsByActorIdsAsync(ICollection<int> actorIds)
        {
            var actors = await this.context.Actors.Where(x => actorIds.Contains(x.ActorId)).ToListAsync().ConfigureAwait(false);
            return actors;
        }
    }
}
