using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NUsers
{
    public partial class NUserRegister
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserRegisterModel? nuserregisterform { get; set; }
        protected override void OnInitialized()
        {
            nuserregisterform = new NUserRegisterModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(nuserregisterform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nuser", content))
            {
                if (message.IsSuccessStatusCode)
                {
                    Console.WriteLine(message.Content);
                }
            }
        }
    }
}
