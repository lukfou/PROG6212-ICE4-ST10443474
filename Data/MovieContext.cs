using ICE4RestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ICE4RestApi.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
