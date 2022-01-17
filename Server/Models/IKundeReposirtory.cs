using KundenManagment1.Shared;


namespace KundenManagment1.Server.Models
{
    public interface IKundeReposirtory
    {
        Task<IEnumerable<Kunde>> GetKunden();


    }
}
