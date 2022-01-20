using KundenManagment1.Shared;
using Microsoft.EntityFrameworkCore;

namespace KundenManagment1.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Kunde>()
                .HasKey(e=>e.KdId);

            builder.Entity<Dept>()
                .HasKey(e => e.Id);
        }
        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Dept> Depts { get; set; }

    }
}
