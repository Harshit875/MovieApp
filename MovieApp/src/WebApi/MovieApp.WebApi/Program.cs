using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Contracts;
using MovieApp.Application.Services;
using MovieApp.Infrastructure.Data;
using MovieApp.Infrastructure.Data.Configurations;
using MovieApp.Infrastructure.Data.Contracts;
using MovieApp.Infrastructure.Data.Implementation;
using System.Text.Json.Serialization;

namespace MovieApp.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddScoped<IActorService, ActorService>();
            builder.Services.AddScoped<IProducerService, ProducerService>();
            builder.Services.AddScoped<IMovieRepository, MovieRepository>();
            builder.Services.AddScoped<IActorRepository, ActorRepository>();
            builder.Services.AddScoped<IProducerRepository, ProducerRepository>();
            // Add services to the container.
            builder.Services.AddDbContext<MovieAppDbContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("sqlconnection"),x=>x.MigrationsAssembly("MovieApp.Infrastructure.Data")));
            builder.Services.AddControllers().AddJsonOptions(x=>x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}