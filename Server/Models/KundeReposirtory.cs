using KundenManagment1.Shared;
using Microsoft.EntityFrameworkCore;


namespace KundenManagment1.Server.Models
{
    public class KundeReposirtory : IKundeReposirtory
    {

        
        private readonly AppDbContext appDbContext;
        public KundeReposirtory(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;   
        }

        public async Task<Dept> GetDept(int id)
        {
           return await appDbContext.Depts
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Kunde> GetKdById(int id)
        {
            return await appDbContext.Kunden
                .FirstOrDefaultAsync(e => e.KdId == id);
        }

        public async Task<IEnumerable<Kunde>> GetKunden()
        {
            return await appDbContext.Kunden
                .Include(e=>e.Dept)
                .ToListAsync();
        }
    }
}
