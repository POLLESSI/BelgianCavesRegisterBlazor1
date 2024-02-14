using BelgianCavesRegisterBlazor1.Client.Models;
using BelgianCavesRegisterBlazor1.Client.Pages.NOwners;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NPersons
{
    public partial class NPersonRegister
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NPersonModel? npersonregisterform {  get; set; }
        protected override void OnInitialized()
        {
            npersonregisterform = new NPersonModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(npersonregisterform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nperson", content))
            {
                if (message.IsSuccessStatusCode)
                {
                    Console.WriteLine(message.Content);
                }
            }
        }
    }
}
