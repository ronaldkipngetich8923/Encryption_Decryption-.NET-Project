using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        public DbSet<Encrypte> Encryptes { get; set; }
        public DbSet<Decrypte> Decryptes { get; set; }
    }
}
