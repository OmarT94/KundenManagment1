
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Net.Http;
using KundenManagment1.Shared;

namespace KundenManagment1.Client.Services
{
    public class KundenService : IkundenService
    {
        private  readonly HttpClient httpClient;
        public KundenService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Dept> GetDept(int id)
        {
            return await httpClient.GetFromJsonAsync<Dept>("Kunden"+"/"+id);
        }

        public async Task<Kunde> GetKdById(int id)
        {
            return await httpClient.GetFromJsonAsync<Kunde>("Kunden/Get" + "/" + id); 
        }

        public async Task<IEnumerable<Kunde>> GetKunden()
        {
            return await httpClient.GetFromJsonAsync<Kunde[]>("Kunden");
        }

        //Task<IEnumerable<Kunde>> IkundenService.GetKunden()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
