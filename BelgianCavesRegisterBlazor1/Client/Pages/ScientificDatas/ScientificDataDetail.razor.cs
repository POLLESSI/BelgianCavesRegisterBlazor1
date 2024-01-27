using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgianCavesRegisterBlazor1.Client.Pages.ScientificDatas
{
    public partial class ScientificDataDetail
    {
        [Inject]
        public HttpClient Client { get; set; }
        public ScientificDataModel? CurrentScientificData { get; set; }
        [Parameter]
        public int ScientificData_Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetScientificData();
        }
        private async Task GetScientificData()
        {
            using (HttpResponseMessage message = await Client.GetAsync("scientificdata" + ScientificData_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentScientificData = JsonConvert.DeserializeObject<ScientificDataModel>(json);
                }
            }
        }
    }
}
