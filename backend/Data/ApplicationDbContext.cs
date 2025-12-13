using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Finance> Finances { get; set; }
        public DbSet<Venue> Venues { get; set; }
    }
}
