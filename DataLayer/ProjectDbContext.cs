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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\Data Source=(local);Initial Catalog=enDec_db;Integrated Security=True;");
        }

    }
}
