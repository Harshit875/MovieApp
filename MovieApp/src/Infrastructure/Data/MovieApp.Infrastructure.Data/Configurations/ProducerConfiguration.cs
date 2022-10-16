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
    public class ProducerConfiguration : IEntityTypeConfiguration<Producer>
    {
        public void Configure(EntityTypeBuilder<Producer> builder)
        {
            builder.HasData(
                new Producer()
                {
                    ProducerId = 1,
                    ProducerName = "Christoper Nolan",
                    DateOfBirth = new DateTime(1970, 7, 30),
                    Sex = "Male",
                    Bio = "Producer"
                }
                );
        }
    }
}
