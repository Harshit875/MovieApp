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
    public class ActorRepository : IActorsRepository
    {
        private MovieAppDbContext context;

        public ActorRepository(MovieAppDbContext context)
        {
            this.context = context; 
        }

        public Task CreateActorAsync(Actor movie)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Actor>> GetActors(ICollection<int> actorIds)
        {
            var actors = await this.context.Actors.Where(x => actorIds.Contains(x.ActorId)).ToListAsync().ConfigureAwait(false);
            return actors;
        }
    }
}
