using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.InteropServices;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Bibliographies
{
    public partial class BibliographyView
    {
        [Inject]
        public HttpClient Client { get; set; }
        public HubConnection hubConnection { get; set; }
        public List<BibliographyModel> BibliographyList { get; set; }
        public int SelectedId { get; set; }
        protected override async Task OnInitializedAsync()
        {
            BibliographyList = new List<BibliographyModel>();
            await GetBibliography();
            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost/bibliographyhub/")).Build();
        }

        private void ClickInfo(int bibliography_Id)
        {
            SelectedId = bibliography_Id;
        }
        private async Task GetBibliography()
        {
            using (HttpResponseMessage message = await Client.GetAsync("bibliography"))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    BibliographyList = JsonConvert.DeserializeObject<List<BibliographyModel>>(json);
                }
            }
        }
    }
}
