using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Data
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasMany(m => m.Actors).WithMany(p => p.Movies).UsingEntity(j => j.ToTable("MovieActors"));

            builder.HasData
                (
                new Movie
                {
                    MovieId = 1,
                    Title = "Interstellar",
                    Plot = "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.",
                    ReleaseDate = new DateTime(2014, 11, 7),
                    ProducerId=1
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "Inception",
                    Plot = "Cobb steals information from his targets by entering their dreams. Saito offers to wipe clean Cobb's criminal history as payment for performing an inception on his sick competitor's son.",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    ProducerId=1
                }
        );
        }
    }
}
