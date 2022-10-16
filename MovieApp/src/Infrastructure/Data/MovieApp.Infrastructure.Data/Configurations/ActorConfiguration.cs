using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Data.Configurations
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(
            new Actor()
            {
                ActorId = 1,
                ActorName = "Matthew McConaughey",
                DateOfBirth = new DateTime(1969, 11, 4),
                Sex = "Male",
                Bio = "Actor"
            },
            new Actor()
            {
                ActorId = 2,
                ActorName = "Jessica Chastain",
                DateOfBirth = new DateTime(1977, 3, 24),
                Sex = "Female",
                Bio = "Actor"
            },
                   new Actor()
                   {
                       ActorId = 3,
                       ActorName = "Leonardo Dicaprio",
                       DateOfBirth = new DateTime(1977, 11, 4),
                       Sex = "Male",
                       Bio = "Actor"
                   },
            new Actor()
            {
                ActorId = 4,
                ActorName = "Cilian Murphy",
                DateOfBirth = new DateTime(1977, 3, 24),
                Sex = "Male",
                Bio = "Actor"
            });
        }
    }
}
