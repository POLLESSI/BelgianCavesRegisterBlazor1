using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Administrators
{
    public partial class ModeratorCreate
    {
        [Inject]
        public HttpClient Client { get; set; }
        public ModeratorModel? moderatorform { get; set; }
        protected override void OnInitialized()
        {
            moderatorform = new ModeratorModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(moderatorform);
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
