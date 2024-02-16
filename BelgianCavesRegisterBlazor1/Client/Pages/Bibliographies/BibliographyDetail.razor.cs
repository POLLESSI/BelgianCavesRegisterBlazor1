using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Bibliographies
{
    public partial class BibliographyDetail
    {
        [Inject]
        public HttpClient Client { get; set; }
        public BibliographyModel? CurrentBibliography { get; set; }
        [Parameter]
        public int Bibliography_Id { get; set; }
        protected override async Task OnParametersSetAsync()
        {
            await GetBibliography();
        }
        private async Task GetBibliography()
        {
            using (HttpResponseMessage message = await Client.GetAsync("bibliography" + Bibliography_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentBibliography = JsonConvert.DeserializeObject<BibliographyModel>(json);
                }
            }
        }
    }
}
