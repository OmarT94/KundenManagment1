using KundenManagment1.Shared;


namespace KundenManagment1.Client.Services
{
    public interface IkundenService
    {
       Task<IEnumerable<Kunde>> GetKunden();
        Task<Dept> GetDept(int id);
        Task<Kunde> GetKdById(int id);    
    }
}
