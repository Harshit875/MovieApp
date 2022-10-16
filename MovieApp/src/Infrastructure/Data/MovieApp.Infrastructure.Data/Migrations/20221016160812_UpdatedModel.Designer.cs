﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.Infrastructure.Data;

#nullable disable

namespace MovieApp.Infrastructure.Data.Migrations
{
    [DbContext(typeof(MovieAppDbContext))]
    [Migration("20221016160812_UpdatedModel")]
    partial class UpdatedModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("ActorsActorId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesMovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorsActorId", "MoviesMovieId");

                    b.HasIndex("MoviesMovieId");

                    b.ToTable("MovieActors", (string)null);
                });

            modelBuilder.Entity("MovieApp.Infrastructure.Data.Entities.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"), 1L, 1);

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            ActorName = "Matthew McConaughey",
                            Bio = "Actor",
                            DateOfBirth = new DateTime(1969, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Sex = "Male"
                        },
                        new
                        {
                            ActorId = 2,
                            ActorName = "Jessica Chastain",
                            Bio = "Actor",
                            DateOfBirth = new DateTime(1977, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Sex = "Female"
                        },
                        new
                        {
                            ActorId = 3,
                            ActorName = "Leonardo Dicaprio",
                            Bio = "Actor",
                            DateOfBirth = new DateTime(1977, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Sex = "Male"
                        },
                        new
                        {
                            ActorId = 4,
                            ActorName = "Cilian Murphy",
                            Bio = "Actor",
                            DateOfBirth = new DateTime(1977, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Sex = "Male"
                        });
                });

            modelBuilder.Entity("MovieApp.Infrastructure.Data.Entities.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("Plot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Poster")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Plot = "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.",
                            ProducerId = 1,
                            ReleaseDate = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Interstellar"
                        },
                        new
                        {
                            MovieId = 2,
                            Plot = "Cobb steals information from his targets by entering their dreams. Saito offers to wipe clean Cobb's criminal history as payment for performing an inception on his sick competitor's son.",
                            ProducerId = 1,
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        });
                });

            modelBuilder.Entity("MovieApp.Infrastructure.Data.Entities.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProducerId"), 1L, 1);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProducerId");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            ProducerId = 1,
                            Bio = "Producer",
                            DateOfBirth = new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProducerName = "Christoper Nolan",
                            Sex = "Male"
                        });
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("MovieApp.Infrastructure.Data.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieApp.Infrastructure.Data.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieApp.Infrastructure.Data.Entities.Movie", b =>
                {
                    b.HasOne("MovieApp.Infrastructure.Data.Entities.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("MovieApp.Infrastructure.Data.Entities.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
