using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace BelgianCavesRegisterBlazor1.Client.Pages.LambdaDatas
{
    public partial class LambdaDataDetail
    {
        [Inject]

        public HttpClient Client { get; set; }

        public LambdaDataModel? CurrentLambdaData { get; set; }
        [Parameter]
        public int LambdaData_Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetLambdaData();
        }
        private async Task GetLambdaData()
        {
            using (HttpResponseMessage message = await Client.GetAsync("lambdadata" + LambdaData_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentLambdaData = JsonConvert.DeserializeObject<LambdaDataModel>(json);
                }
            }
        }
    }
}
