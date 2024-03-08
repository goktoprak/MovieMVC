using Microsoft.EntityFrameworkCore;
using MovieModels.Models;

namespace MovieDataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> MovieTable { get; set; }
    }
}
