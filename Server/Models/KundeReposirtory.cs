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

        public  async Task<IEnumerable<Dept>> GetDeptAll()
        {
            return await appDbContext.Depts
               .ToListAsync();
        }

        public async Task<Kunde> GetKdById(int id)
        {
            //return await appDbContext.Kunden
            //    .FirstOrDefaultAsync(e => e.KdId == id);
            return await appDbContext.Kunden
                .Select(x => new Kunde
                {
                    KdStraße = x.KdStraße,
                    KdHausNummer=x.KdHausNummer,
                    KdPLZ=x.KdPLZ,
                    KdStadt=x.KdStadt,
                    DeptId = x.DeptId,
                    KdId = x.KdId,
                    KdVorname=x.KdVorname,
                    KdName = x.KdName,
                    KdImgPath = x.KdImgPath,
                    KdAlter = x.KdAlter,
                    Dept = appDbContext.Depts.ToList()
                })
                .FirstOrDefaultAsync(e => e.KdId == id);
        }

        public async Task<IEnumerable<Kunde>> GetKunden()
        {
            return await appDbContext.Kunden
                .Include(e=>e.Dept)
                .ToListAsync();
        }

        public async Task<Kunde> UpdateKunde(Kunde kunde)
        {
            appDbContext.Entry(kunde).State=EntityState.Modified;
            await appDbContext.SaveChangesAsync();
            return kunde;
        }
    }
}
