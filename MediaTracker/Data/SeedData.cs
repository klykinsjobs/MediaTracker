using Microsoft.EntityFrameworkCore;
using MediaTracker.Models;

namespace MediaTracker.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            if (context == null || context.Book == null || context.Game == null || context.Show == null || context.Movie == null)
            {
                throw new NullReferenceException("Null ApplicationDbContext or DbSet");
            }

            if (context.Book.Any() || context.Game.Any() || context.Show.Any() || context.Movie.Any())
            {
                return;
            }

            context.Book.AddRange(
                new Book { Title = "Book A", Author = "Author A", Genre = "Adventure", Finished = true, Rating = 10, Notes = "It was ok" },
                new Book { Title = "Book B", Author = "Author B", Genre = "Adventure", Finished = true },
                new Book { Title = "Book C", Author = "Author C", Genre = "Sci-fi", Finished = false },
                new Book { Title = "Book D", Author = "Author D", Genre = "Sci-fi", Finished = false, Rating = 1, Notes = "DNF" },
                new Book { Title = "Book E", Author = "Author E", Genre = "Comedy", Finished = true, Rating = 9 },
                new Book { Title = "Book F", Author = "Author F", Genre = "Comedy", Finished = false }
                );

            context.Game.AddRange(
                new Game { Title = "Game A", Genre = "RPG", Finished = true, Rating = 10, Notes = "It was ok" },
                new Game { Title = "Game B", Genre = "RPG", Finished = true },
                new Game { Title = "Game C", Genre = "FPS", Finished = false },
                new Game { Title = "Game D", Genre = "FPS", Finished = false, Rating = 1, Notes = "DNF" },
                new Game { Title = "Game E", Genre = "Strategy", Finished = true, Rating = 9 },
                new Game { Title = "Game F", Genre = "Strategy", Finished = false }
                );

            context.Show.AddRange(
                new Show { Title = "Show A", Genre = "Mystery", Finished = true, Rating = 10, Notes = "It was ok" },
                new Show { Title = "Show B", Genre = "Mystery", Finished = true },
                new Show { Title = "Show C", Genre = "Drama", Finished = false },
                new Show { Title = "Show D", Genre = "Drama", Finished = false, Rating = 1, Notes = "DNF" },
                new Show { Title = "Show E", Genre = "Action", Finished = true, Rating = 9 },
                new Show { Title = "Show F", Genre = "Action", Finished = false }
                );

            context.Movie.AddRange(
                new Movie { Title = "Movie A", Genre = "Thriller", Finished = true, Rating = 10, Notes = "It was ok" },
                new Movie { Title = "Movie B", Genre = "Thriller", Finished = true },
                new Movie { Title = "Movie C", Genre = "Suspense", Finished = false },
                new Movie { Title = "Movie D", Genre = "Suspense", Finished = false, Rating = 1, Notes = "DNF" },
                new Movie { Title = "Movie E", Genre = "Sports", Finished = true, Rating = 9 },
                new Movie { Title = "Movie F", Genre = "Sports", Finished = false }
                );

            context.SaveChanges();
        }
    }
}
