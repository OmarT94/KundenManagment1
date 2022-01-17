using KundenManagment1.Shared;
using Microsoft.EntityFrameworkCore;

namespace KundenManagment1.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Kunde> Kunden { get; set; }
    }
}
