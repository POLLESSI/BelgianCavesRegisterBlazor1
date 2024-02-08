using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Moderators
{
    public partial class ModeratorDetail
    {
        [Inject]
        public HttpClient Client { get; set; }
        public ModeratorModel? CurrentModerator { get; set; }
        [Parameter]
        public int Moderator_Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetModerator();
        }
        private async Task GetModerator()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nuser" + Moderator_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentModerator = JsonConvert.DeserializeObject<ModeratorModel>(json);
                }
            }
        }
    }
}
