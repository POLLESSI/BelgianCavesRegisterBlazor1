using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NPersons
{
    public partial class NPersonDetail
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NPersonModel? CurrentNPerson { get; set; }
        [Parameter]
        public int NPerson_Id { get; set; }
        protected override async Task OnParametersSetAsync()
        {
            await GetNPerson();
        }

        private async Task GetNPerson()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nperson" + NPerson_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentNPerson = JsonConvert.DeserializeObject<NPersonModel>(json);
                }
            }
        }
    }
}
