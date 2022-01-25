using KundenManagment1.Shared;


namespace KundenManagment1.Server.Models
{
    public interface IKundeReposirtory
    {
        Task<IEnumerable<Kunde>> GetKunden();
        Task<Dept> GetDept(int id);
        Task<Kunde> GetKdById(int id);
        Task <Kunde> UpdateKunde(Kunde kunde);

        
    }
}
