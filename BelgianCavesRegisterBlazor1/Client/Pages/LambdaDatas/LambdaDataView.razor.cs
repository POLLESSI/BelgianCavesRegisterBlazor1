using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.ExceptionServices;
using BelgianCavesRegisterBlazor1.Client.Models;

namespace BelgianCavesRegisterBlazor1.Client.Pages.LambdaDatas
{
    public partial class LambdaDataView
    {
        [Inject]
        public HttpClient Client { get; set; }

        public HubConnection? hubConnection { get; set; }
        public List<LambdaDataModel>? LambdaDataList { get; set; }

        public int SelectedId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            LambdaDataList = new List<LambdaDataModel>();
            await GetLambdaData();
            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7044/lambdadatahub/")).Build();
        }

        private void ClickInfo(int lambdaData_Id)
        {
            SelectedId = lambdaData_Id;
        }

        private async Task GetLambdaData()
        {
            using (HttpResponseMessage message = await Client.GetAsync("lambdadata"))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    LambdaDataList = JsonConvert.DeserializeObject<List<LambdaDataModel>>(json);
                }
            }
        }
    }
}
