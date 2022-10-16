using AutoMapper;
using MovieApp.Infrastructure.Data.Entities;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application
{
    public class MovieMapper : Profile
    {
        public MovieMapper()
        {
            CreateMap<MovieDto, Movie>()
                .ForMember(des => des.ProducerId, opt => opt.MapFrom(src => src.ProducerId))
                .ForMember(des => des.Actors., opt => opt.MapFrom(src => src.ActorIds)
            CreateMap<ProducerDto, Producer>();
            CreateMap<ActorDto, Actor>();
        }
    }
}
