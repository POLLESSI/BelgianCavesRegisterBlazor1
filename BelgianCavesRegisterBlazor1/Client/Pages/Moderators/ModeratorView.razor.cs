using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.InteropServices;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Moderators
{
    public partial class ModeratorView
    {
        [Inject]
        public HttpClient Client { get; set; }
        public HubConnection hubConnection { get; set; }
        public List<ModeratorModel> ModeratorList { get; set; }

        public int SelectedId { get; set; }
        protected override async Task OnInitializedAsync()
        {
            ModeratorList = new List<ModeratorModel>();
            await GetModerator();
            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7044/nuserhub")).Build();
        }
        private void ClickInfo(int moderator_Id)
        {
            SelectedId = moderator_Id;
        }
        private async Task GetModerator()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nuser"))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    ModeratorList = JsonConvert.DeserializeObject<List<ModeratorModel>>(json);
                }
            }
        }
    }
}
