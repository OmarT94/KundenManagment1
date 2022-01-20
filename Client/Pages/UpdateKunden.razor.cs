using KundenManagment1.Client.Services;
using KundenManagment1.Shared;
using Microsoft.AspNetCore.Components;

namespace KundenManagment1.Client.Pages
{
    public partial class UpdateKunden :ComponentBase
    {
        public Kunde kunde { get; set; }= new Kunde();



        [Parameter]
        public Dept Depts { get; set; }=new Dept();

        [Parameter]
        public string id { get; set; }
        public Kunde Kunde { get; set; }


        [Inject]
        public IkundenService KundenService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            kunde = (await KundenService.GetKdById(Convert.ToInt32(id)));
        }

    }
}
