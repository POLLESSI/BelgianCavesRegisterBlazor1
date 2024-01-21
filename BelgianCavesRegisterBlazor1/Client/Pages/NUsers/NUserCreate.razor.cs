using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NUsers
{
    public partial class NUserCreate
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserModel? nUserform { get; set; }

        protected override void OnInitialized()
        {
            nUserform = new NUserModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(nUserform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nuser", content))
            {
                if (message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
