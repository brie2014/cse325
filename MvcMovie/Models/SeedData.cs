using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Singles Ward",
                    ReleaseDate = DateTime.Parse("2002-8-30"),
                    Genre = Movie.MovieGenre.Comedy,
                    Rating = "PG",
                    Price = 7.99M,
                    ImageName = "https://m.media-amazon.com/images/M/MV5BMTQyNDAwNjc4M15BMl5BanBnXkFtZTYwMzQ5NDk5._V1_.jpg"
                },
                new Movie
                {
                    Title = "Singles Ward 2",
                    ReleaseDate = DateTime.Parse("2007-3-13"),
                    Genre = Movie.MovieGenre.Comedy,
                    Rating = "PG",
                    Price = 8.99M,
                    ImageName= "https://m.media-amazon.com/images/M/MV5BMTM2OTExMjg2OF5BMl5BanBnXkFtZTcwMDcyMzU1MQ@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Title = "The Best Two Years",
                    ReleaseDate = DateTime.Parse("2003-2-23"),
                    Genre = Movie.MovieGenre.Comedy,
                    Rating = "PG",
                    Price = 9.99M,
                    ImageName= "https://m.media-amazon.com/images/M/MV5BMjEzMzc5MjQ4NV5BMl5BanBnXkFtZTYwNjY1MjE3._V1_.jpg"
                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-4-15"),
                    Genre = Movie.MovieGenre.Drama,
                    Rating = "PG",
                    Price = 3.99M,
                    ImageName= "https://m.media-amazon.com/images/M/MV5BNTkzZWRmMWQtZDc2YS00MzIzLTljMTUtYTVkM2I5Yzg4OTMzL2ltYWdlXkEyXkFqcGdeQXVyNDcxMTk4Mzc@._V1_.jpg"
                }
            );
            context.SaveChanges();
        }
    }
}