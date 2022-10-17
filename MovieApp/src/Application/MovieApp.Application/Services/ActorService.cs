using AutoMapper;
using MovieApp.Application.Contracts;
using MovieApp.Infrastructure.Data.Contracts;
using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository actorRepository;
        private readonly IMapper mapper;
        public ActorService(IActorRepository actorRepository, IMapper mapper)
        {
            this.actorRepository = actorRepository;
            this.mapper = mapper;   
        }

        public async Task<IEnumerable<Actor>> GetActorsAsync()
        {
            var actors = await this.actorRepository.GetActorsAsync();
            return actors;
        }
        public async Task CreateActorAsync(ActorDto actorDto)
        {
            var actorEntity = this.mapper.Map<Actor>(actorDto);
            await this.actorRepository.CreateActorAsync(actorEntity);
        }
    }
}
