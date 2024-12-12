using Microsoft.EntityFrameworkCore;
using MovieApp.Entity.Models;

namespace MovieApp.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<TvShow> TvShows { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
