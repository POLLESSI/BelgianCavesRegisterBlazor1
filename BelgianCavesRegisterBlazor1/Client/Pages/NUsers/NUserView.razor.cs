using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.ExceptionServices; 

namespace BelgianCavesRegisterBlazor1.Client.Pages.NUsers
{
    public partial class NUserView
    {
        [Inject]
        public HttpClient Client { get; set; }
        public HubConnection? hubConnection { get; set; }
        public List<NUserModel>? NUsersList { get; set; }
        public int SelectedId { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            NUsersList = new List<NUserModel>();
            await GetNUser();
            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7044/nuserhub")).Build();
        }
        
        private void ClicInfo(int nUser_Id)
        {
            SelectedId = nUser_Id;
        }

        private async Task GetNUser()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nuser"))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    JsonConvert.DeserializeObject<NUserModel>(json);
                }
            }
        }
    }
}
