using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Administrators
{
    public partial class AdministratorLogin
    {
        [Inject]
        public HttpClient Client { get; set; }
        public AdministratorLoginModel? administratorloginform { get; set; }
        protected override void OnInitialized()
        {
            administratorloginform = new AdministratorLoginModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(administratorloginform);
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
