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
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Singles Ward 2",
                    ReleaseDate = DateTime.Parse("2007-3-13"),
                    Genre = Movie.MovieGenre.Comedy,
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The Best Two Years",
                    ReleaseDate = DateTime.Parse("2003-2-23"),
                    Genre = Movie.MovieGenre.Comedy,
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-4-15"),
                    Genre = Movie.MovieGenre.Drama,
                    Rating = "PG",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}