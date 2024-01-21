using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.ExceptionServices;
using BelgianCavesRegisterBlazor1.Client.Models;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NOwners
{
    public partial class NOwnerView
    {
        [Inject]
        public HttpClient Client { get; set; }
        public HubConnection hubConnection { get; set; }
        public List<NOwnerModel> NOwnerList { get; set; }

        public int SelectedId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            NOwnerList = new List<NOwnerModel>();
            await GetNOwner();
            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7017/npersonhub")).Build();
        }

        private void ClickInfo(int nowner_Id)
        {
            SelectedId = nowner_Id;
        }
        private async Task GetNOwner()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nowner"))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    NOwnerList = JsonConvert.DeserializeObject<List<NOwnerModel>>(json);
                }
            }
        }
    }
}
