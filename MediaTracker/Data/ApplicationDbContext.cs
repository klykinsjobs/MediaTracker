using Microsoft.EntityFrameworkCore;
using MediaTracker.Models;

namespace MediaTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<Game> Game { get; set; } = default!;
        public DbSet<Show> Show { get; set; } = default!;
        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
