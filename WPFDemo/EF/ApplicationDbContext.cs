using Microsoft.EntityFrameworkCore;
using WPFDemo.EF.Models;

namespace WPFDemo.EF
{
    public class ApplicationDbContext : DbContext
    {
        private const string CONNECTION_STRING = "Provide a connection string here";
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(CONNECTION_STRING);
            }
        }
    }
}
