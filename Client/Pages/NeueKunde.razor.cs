using KundenManagment1.Client.Services;
using KundenManagment1.Shared;
using Microsoft.AspNetCore.Components;

namespace KundenManagment1.Client.Pages
{
    public partial class NeueKunde: ComponentBase
    {
        public Kunde kunde { get; set; } = new Kunde();



        [Parameter]
        public Dept Depts { get; set; } = new Dept();

        [Parameter]
        public string id { get; set; }
        public Kunde Kunde { get; set; }


        [Inject]
        public IkundenService KundenService { get; set; }
        public IEnumerable<Dept> Dept { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Dept = (await KundenService.GetDeptAll()).ToList();
            //LoadKunden();
        }
        public async void GetDepartment(int id)
        {
            Depts = await KundenService.GetDept(id);
        }
        public async void HandleValidSubmit()
        {
            var result = (await KundenService.UpdateKunde(kunde));
        }

       

    }
}
