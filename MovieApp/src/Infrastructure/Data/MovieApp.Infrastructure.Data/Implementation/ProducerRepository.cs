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
    public class ProducerRepository : IProducerRepository
    {
        private MovieAppDbContext context;

        public ProducerRepository(MovieAppDbContext context)
        {
            this.context = context; 
        }

        public async Task CreateProducerAsync(Producer producer)
        {
            await this.context.AddAsync(producer);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Producer>> GetProducersAsync()
        {
            return await this.context.Producers.ToListAsync().ConfigureAwait(false);
        }
    }
}
