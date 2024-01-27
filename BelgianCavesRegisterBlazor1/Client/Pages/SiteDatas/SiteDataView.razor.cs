using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.ExceptionServices;
using BelgianCavesRegisterBlazor1.Client.Models;

namespace BelgianCavesRegisterBlazor1.Client.Pages.SiteDatas
{
    public partial class SiteDataView
    {
        [Inject]
        public HttpClient Client { get; set; }
        public HubConnection? hubConnection { get; set; }
        public List<SiteDataModel>? SiteDatasList { get; set; }
        public int SelectedId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SiteDatasList = new List<SiteDataModel>();
            await GetSiteData();
            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7044/scientificdatahub")).Build();
        }

        private void ClickInfo(int siteData_Id)
        {
            SelectedId = siteData_Id;
        }

        private async Task GetSiteData()
        {
            using(HttpResponseMessage message = await Client.GetAsync("sitedata"))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    JsonConvert.DeserializeObject<SiteDataModel>(json);
                }
            }
        }
    }
}
