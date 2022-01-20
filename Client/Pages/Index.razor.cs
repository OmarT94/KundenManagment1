using KundenManagment1.Client.Services;
using KundenManagment1.Shared;
using Microsoft.AspNetCore.Components;

namespace KundenManagment1.Client.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IkundenService KundenService { get; set; }
   
        public IEnumerable<Kunde> Kunden { get; set; }
        public Dept Depts { get; set; }
        [Inject]
         public NavigationManager NavigationManager { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Kunden = (await KundenService.GetKunden()).ToList();
            //LoadKunden();
        }

        public async Task GetDepartment(int id)
        {
            Depts= await KundenService.GetDept(id);
            NavigationManager.NavigateTo($"/dept/{Depts.DeptName}");
        }

        public void Update_Kunde(int id)
        {
            
            NavigationManager.NavigateTo($"/update/{id}", true);
        }


        //private void LoadKunden()
        //{
        //    System.Threading.Thread.Sleep(30);
        //    Kunde k1 = new Kunde
        //    {
        //        KdId = 1,
        //        KdName = "Omar",
        //        KdAdresse = "HH",
        //        KdImgPath = "img/55.JPG"
        //    };

        //    Kunde k2 = new Kunde
        //    {
        //        KdId = 2,
        //        KdName = "Mohammad",
        //        KdAdresse = "HH",
        //        KdImgPath = "img/2.JPG"
        //    };

        //    Kunde k3 = new Kunde
        //    {
        //        KdId = 3,
        //        KdName = "Danisch",
        //        KdAdresse = "HH",
        //        KdImgPath = "img/3.JPG"
        //    };

        //    Kunde k4 = new Kunde
        //    {
        //        KdId = 4,
        //        KdName = "Rudi",
        //        KdAdresse = "HH",
        //        KdImgPath = "img/4.JPG"
        //    };

        //    Kunden = new List<Kunde> { k1, k2, k3, k4 };



        //}
    }
}
