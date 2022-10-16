using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApp.Infrastructure.Data.Migrations
{
    public partial class AddedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorName", "Bio", "DateOfBirth", "Sex" },
                values: new object[,]
                {
                    { 1, "Matthew McConaughey", "Actor", new DateTime(1969, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male" },
                    { 2, "Jessica Chastain", "Actor", new DateTime(1977, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female" },
                    { 3, "Leonardo Dicaprio", "Actor", new DateTime(1977, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male" },
                    { 4, "Cilian Murphy", "Actor", new DateTime(1977, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ProducerId", "Bio", "DateOfBirth", "ProducerName", "Sex" },
                values: new object[] { 1, "Producer", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christoper Nolan", "Male" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Plot", "Poster", "ProducerId", "ReleaseDate", "Title" },
                values: new object[] { 1, "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.", null, 1, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Plot", "Poster", "ProducerId", "ReleaseDate", "Title" },
                values: new object[] { 2, "Cobb steals information from his targets by entering their dreams. Saito offers to wipe clean Cobb's criminal history as payment for performing an inception on his sick competitor's son.", null, 1, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 1);
        }
    }
}
