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
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository producerRepository;
        private readonly IMapper mapper;
        public ProducerService(IProducerRepository producerRepository, IMapper mapper)
        {
            this.producerRepository = producerRepository;
            this.mapper = mapper;   
        }

        public async Task<IEnumerable<Producer>> GetProducersAsync()
        {
            var producers = await this.producerRepository.GetProducersAsync();
            return producers;
        }
        public async Task CreateProducerAsync(ProducerDto producerDto)
        {
            var producerEntity = this.mapper.Map<Producer>(producerDto);
            await this.producerRepository.CreateProducerAsync(producerEntity);
        }
    }
}
