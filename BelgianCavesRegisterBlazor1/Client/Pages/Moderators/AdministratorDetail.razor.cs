using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Moderators
{
    public partial class AdministratorDetail
    {
        [Inject]
        public HttpClient Client { get; set; }
        public AdministratorModel? CurrentAdministrator { get; set; }

        [Parameter]
        public int Administrator_Id { get; set;}
        
        protected override async Task OnParametersSetAsync()
        {
            await GetAdministrator();
        }
        private async Task GetAdministrator()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nuser" + Administrator_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentAdministrator = JsonConvert.DeserializeObject<AdministratorModel>(json);
                }
            }
        }
    }
}
