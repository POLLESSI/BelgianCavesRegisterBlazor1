using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NOwners
{
    public partial class NOwnerDetail
    {
        [Inject]

        public HttpClient Client { get; set; }

        public NOwnerModel? CurrentNOwner { get; set; }

        [Parameter]
        public int NOwner_Id { get; set; }
        [Parameter]
        public object? ValueFromNOwnerDetail { get; set; }
        
        protected override async Task OnParametersSetAsync()
        {
            await GetNOwner();
        }

        private async Task GetNOwner()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nowner" + NOwner_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentNOwner = JsonConvert.DeserializeObject<NOwnerModel>(json);
                }
            }
        }
    }
}
