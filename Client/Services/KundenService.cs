
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Net.Http;
using KundenManagment1.Shared;
using Microsoft.AspNetCore.Http.Extensions;



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

        public async Task<IEnumerable<Dept>> GetDeptAll()
        {
            return await httpClient.GetFromJsonAsync<Dept[]>("Kunden/Dept");
        }

        public async Task<Kunde> GetKdById(int id)
        {
            return await httpClient.GetFromJsonAsync<Kunde>("Kunden/Get" + "/" + id); 
        }

        

        public async Task<IEnumerable<Kunde>> GetKunden()
        {
            return await httpClient.GetFromJsonAsync<Kunde[]>("Kunden");
        }

        public async Task<Kunde> UpdateKunde(Kunde kunde)
        {
            //return await httpClient.PostAsJsonAsync<Kunde>("Kunden /update", kunde);


            HttpResponseMessage message = await httpClient.PostAsJsonAsync<Kunde>("Kunden/update",kunde);
            return kunde;

        }

        //public async Task<Kunde> UpdateKunde2(Kunde kunde)
        //{
        //    return null;
        //}

        // Accessor     Rückgabewert    Name            Parameter
        // public       void            Bla             ()
        //              Task<Kunde>     UpdateKunde2    Kunde kunde

        //Task<IEnumerable<Kunde>> IkundenService.GetKunden()
        //{
        //    throw new NotImplementedException();
        //}

       

        
    }
}
