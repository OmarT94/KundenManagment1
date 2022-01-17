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
        public async Task<IEnumerable<Kunde>> GetKunden()
        {
            return await appDbContext.Kunden.ToListAsync();
        }
    }
}
