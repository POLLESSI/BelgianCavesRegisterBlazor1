using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.ExceptionServices;
using BelgianCavesRegisterBlazor1.Client.Models;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Moderators
{
    public partial class LambdaDataView
    {
        [Inject]
        public HttpClient Client { get; set; }

        public HubConnection hubConnection { get; set; }
        public List<LambdaDataModel>? LambdaDataList { get; set; }
        //public object? ValueFromLambdadataDetail { get; set; }
        //public object? ValueFromLambdaDataCreate { get; set; }

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

        //private void ReceiveEventInvokeDetailLambdaData(object value)
        //{
        //    ValueFromLambdadataDetail = value;
        //}

        //private void ReceiveEventInvokeCreateLambdaData(object value)
        //{
        //    ValueFromLambdaDataCreate = value;
        //}

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
