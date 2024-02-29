using Microsoft.EntityFrameworkCore;

namespace apiSample.Models
{
    public class sDbContext : DbContext
    {

        public sDbContext(DbContextOptions<sDbContext> options) : base(options)
        {
        }
        public DbSet<book> books { get; set; }
        public DbSet<group> groups { get; set; }
        public DbSet<sBooks> sBooks { get; set; }
        public DbSet<Student> students { get; set; }

    }
}
