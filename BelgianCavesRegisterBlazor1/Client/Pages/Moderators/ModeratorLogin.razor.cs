using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Moderators
{
    public partial class ModeratorLogin
    {
        [Inject]
        public HttpClient Client { get; set; }
        public ModeratorLoginModel? moderatorloginform { get; set; }
        protected override void OnInitialized()
        {
            moderatorloginform = new ModeratorLoginModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(moderatorloginform);
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
