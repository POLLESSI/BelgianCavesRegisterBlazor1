using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.ScientificDatas
{
    public partial class ScientificDataCreate
    {
        [Inject]
        public HttpClient Client { get; set; }
        public ScientificDataModel? scientificDataform { get; set; }

        [Parameter]
        public object? ValueFromScientificDataCreate { get; set; }

        [Parameter]

        public EventCallback<object> EventCreateScientificData { get; set; }

        protected void ExecuteEventCreateScientificData()
        {
            EventCreateScientificData.InvokeAsync(ValueFromScientificDataCreate);
        }

        protected override void OnInitialized()
        {
            scientificDataform = new ScientificDataModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(scientificDataform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("scientificdata", content))
            {
                if (message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
