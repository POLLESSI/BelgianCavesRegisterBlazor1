using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.InteropServices;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Moderators
{
    public partial class AdministratorView
    {
        [Inject]
        public HttpClient Client { get; set; }
        public HubConnection hubConnection { get; set; }
        public List<AdministratorModel>? AdministratorList { get; set; }
        public int SelectedId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AdministratorList = new List<AdministratorModel>();
            await GetAdministrator();
            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7044/nuserhub/")).Build();
        }
        private void ClickInfo(int administrator_Id)
        {
            SelectedId = administrator_Id;
        }
        private async Task GetAdministrator()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nuser"))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    AdministratorList = JsonConvert.DeserializeObject<List<AdministratorModel>>(json);
                }
            }
        }
    }
}
