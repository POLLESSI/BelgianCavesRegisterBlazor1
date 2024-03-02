using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NUsers
{
    public partial class NUserLogin
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserLoginModel? nuserloginform { get; set; }
        public NUserRegisterModel nUser { get; set; }
        private const int AdministratorRoleId = 1;
        private const int ModeratorRoleId = 2;
        protected override void OnInitialized()
        {
            nuserloginform = new NUserLoginModel();
            nUser = new NUserRegisterModel();
        }
        private string navmenuadministratorpage = "/administrators/navmenuadministrator";
        private string administratorcreatepage = "/administrators/administratorcreate";
        private string bibliographycreatepage = "/administrators/bibliographycreate";
        private string lambdadatacreatepage = "/administrators/lambdadatacreate";
        private string moderatorcreatepage = "/administrators/moderatorcreate";
        private string nownercreatepage = "/administrators/nownercreate";
        private string npersoncreatepage = "/administrators/npersoncreate";
        private string nusercreatepage = "/administrators/nusercreate";
        private string scientificdatapage = "/administrators/scientificdatacreate";
        private string sitedatacreatepage = "/administrators/sitedatacreate";
        private string navmenumoderatorpage = "/moderators/navmenumoderator";
        private string administratorviewpage = "/moderators/administratorview";
        private string bibliographyviewpage = "/moderators/bibliographyview";
        private string lambdadataviewpage = "/moderators/lambdadataview";
        private string moderatorviewpage = "/moderators/moderatorview";
        private string nownerviewpage = "/moderators/nownerview";
        private string npersonviewpage = "/moderators/npersonview";
        private string nuserviewpage = "/moderators/nuserview";
        private string scientificdataviewpage = "/moderators/scientificdataview";
        private string sitedataviewpage = "/sitedatas/sitedataview";
        private string bibliographydetailpage = "/bibliographies/bibliographydetail";
        private string lambdadatadetailpage = "/lambdadatas/lambdadatadetail";
        private string nownerdetailpage = "/nowners/nownerdetail";
        private string npersondetailpage = "/nperson/npersondetail";
        private string npersonregisterpage = "/npersons/npersonregister";
        private string nuserdetailpage = "/nusers/nuserdetail";
        private string nuserloginpage = "/nusers/nuserlogin";
        private string nuserregisterpage = "/nusers/nuserregister";
        private string scientificdatadetailpage = "/scientificdatas/scientificdatadetail";
        private string sitedatadetailpage = "/sitedatas/sitedatadetail";
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(nuserloginform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                using (HttpResponseMessage message = await Client.PostAsync("nuser", content))
                {
                    if (!message.IsSuccessStatusCode)
                    {
                        Console.WriteLine(message.Content);
                    }
                }
                NavigateBasedOnRole();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error NavigateBasedOnRole : {ex.ToString}");
            }
        }
        private void NavigateBasedOnRole()
        {
            switch (nUser.Role_Id)
            {
                case AdministratorRoleId:
                    NavigateToAdministratorPages();
                    break;

                case ModeratorRoleId:
                    NavigateToModeratorPages();
                    break;

                default:
                    NavigateToDefaultPages();
                    break;
            }
        }
        private void NavigateToAdministratorPages()
        {
            NavigationManager.NavigateTo(navmenuadministratorpage);
            NavigationManager.NavigateTo(administratorcreatepage);
            NavigationManager.NavigateTo(bibliographycreatepage);
            NavigationManager.NavigateTo(lambdadatacreatepage);
            NavigationManager.NavigateTo(moderatorcreatepage);
            NavigationManager.NavigateTo(nownercreatepage);
            NavigationManager.NavigateTo(npersoncreatepage);
            NavigationManager.NavigateTo(nusercreatepage);
            NavigationManager.NavigateTo(scientificdatapage);
            NavigationManager.NavigateTo(sitedatacreatepage);
            NavigationManager.NavigateTo(navmenumoderatorpage);
            NavigationManager.NavigateTo(administratorviewpage);
            NavigationManager.NavigateTo(bibliographyviewpage);
            NavigationManager.NavigateTo(lambdadataviewpage);
            NavigationManager.NavigateTo(moderatorviewpage);
            NavigationManager.NavigateTo(nownerviewpage);
            NavigationManager.NavigateTo(npersonviewpage);
            NavigationManager.NavigateTo(nuserviewpage);
            NavigationManager.NavigateTo(scientificdataviewpage);
            NavigationManager.NavigateTo(sitedataviewpage);
            NavigationManager.NavigateTo(bibliographydetailpage);
            NavigationManager.NavigateTo(lambdadatadetailpage);
            NavigationManager.NavigateTo(nownerdetailpage);
            NavigationManager.NavigateTo(npersondetailpage);
            NavigationManager.NavigateTo(npersonregisterpage);
            NavigationManager.NavigateTo(nuserdetailpage);
            NavigationManager.NavigateTo(nuserloginpage);
            NavigationManager.NavigateTo(nuserregisterpage);
            NavigationManager.NavigateTo(scientificdatadetailpage);
            NavigationManager.NavigateTo(sitedatadetailpage);
        }

        private void NavigateToModeratorPages()
        {
            NavigationManager.NavigateTo(navmenumoderatorpage);
            NavigationManager.NavigateTo(administratorviewpage);
            NavigationManager.NavigateTo(bibliographyviewpage);
            NavigationManager.NavigateTo(lambdadataviewpage);
            NavigationManager.NavigateTo(moderatorviewpage);
            NavigationManager.NavigateTo(nownerviewpage);
            NavigationManager.NavigateTo(npersonviewpage);
            NavigationManager.NavigateTo(nuserviewpage);
            NavigationManager.NavigateTo(scientificdataviewpage);
            NavigationManager.NavigateTo(sitedataviewpage);
            NavigationManager.NavigateTo(bibliographydetailpage);
            NavigationManager.NavigateTo(lambdadatadetailpage);
            NavigationManager.NavigateTo(nownerdetailpage);
            NavigationManager.NavigateTo(npersondetailpage);
            NavigationManager.NavigateTo(npersonregisterpage);
            NavigationManager.NavigateTo(nuserdetailpage);
            NavigationManager.NavigateTo(nuserloginpage);
            NavigationManager.NavigateTo(nuserregisterpage);
            NavigationManager.NavigateTo(scientificdatadetailpage);
            NavigationManager.NavigateTo(sitedatadetailpage);
        }
        private void NavigateToDefaultPages()
        {
            NavigationManager.NavigateTo(bibliographydetailpage);
            NavigationManager.NavigateTo(lambdadatadetailpage);
            NavigationManager.NavigateTo(nownerdetailpage);
            NavigationManager.NavigateTo(npersondetailpage);
            NavigationManager.NavigateTo(npersonregisterpage);
            NavigationManager.NavigateTo(nuserdetailpage);
            NavigationManager.NavigateTo(nuserloginpage);
            NavigationManager.NavigateTo(nuserregisterpage);
            NavigationManager.NavigateTo(scientificdatadetailpage);
            NavigationManager.NavigateTo(sitedatadetailpage);
        }
    }
}
