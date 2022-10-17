using AutoMapper;
using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Mapper
{
    public class ProducerMapper : Profile
    {
        public ProducerMapper()
        {
            CreateMap<ProducerDto, Producer>();
        }
    }
}
