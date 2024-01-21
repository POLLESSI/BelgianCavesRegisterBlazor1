using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.ExceptionServices;
using BelgianCavesRegisterBlazor1.Client.Models;

namespace BelgianCavesRegisterBlazor1.Client.Pages.ScientificDatas
{
    public partial class ScientificDataView
    {
        [Inject]

        public HttpClient Client { get; set; }
        public HubConnection hubConnection { get; set; }
        public List<ScientificDataModel> ScientificDatasList { get; set; }
        public int SelectedId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ScientificDatasList = new List<ScientificDataModel>();
            await GetScientificData();
            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7017/scientificdatahub")).Build();
        }

        private void ClickInfo(int scientificData_Id)
        {
            SelectedId = scientificData_Id;
        }

        private async Task GetScientificData()
        {
            using(HttpResponseMessage message = await Client.GetAsync("scientificdata"))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    JsonConvert.DeserializeObject<ScientificDataModel>(json);
                }
            }
        }
    }
}
