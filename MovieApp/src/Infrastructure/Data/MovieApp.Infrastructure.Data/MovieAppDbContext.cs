using Microsoft.EntityFrameworkCore;
using MovieApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Data
{
    public class MovieAppDbContext : DbContext
    {
        public MovieAppDbContext(DbContextOptions options): base(options)
        {

        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieAppConfiguration());
        }
        public DbSet<Movie> Movies { get; set; }   
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Producer> Producers { get; set; }  
        
    }
}
