using KundenManagment1.Shared;


namespace KundenManagment1.Client.Services
{
    public interface IkundenService
    {
       Task<IEnumerable<Kunde>> GetKunden();
    }
}
