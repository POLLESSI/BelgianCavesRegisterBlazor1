using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Bibliographies
{
    public partial class BibliographyCreate
    {
        [Inject]
        public HttpClient Client { get; set; }
        public BibliographyModel? bibliographyform { get; set; }
        [Parameter]
        public object? ValueFromChild2 { get; set; }
        [Parameter]
        public EventCallback<object> EventCreateBibliography { get; set; }

        protected void ExecxuteEventCreateBibliography()
        {
            EventCreateBibliography.InvokeAsync(ValueFromChild2);
        }

        protected override void OnInitialized()
        {
            bibliographyform = new BibliographyModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(bibliographyform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("bibliography", content))
            {
                if (message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
