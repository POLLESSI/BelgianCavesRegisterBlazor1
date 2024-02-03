using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.SiteDatas
{
    public partial class SiteDataCreate
    {
        [Inject]
        public HttpClient Client { get; set; }
        public SiteDataModel? siteDataform { get; set; }
        [Parameter]
        public object? ValueFromSiteDataCreate { get; set; }
        [Parameter]
        public EventCallback<object> EventCreateSiteData { get; set; }
        protected void ExecuteEventCreateSiteData()
        {
            EventCreateSiteData.InvokeAsync(ValueFromSiteDataCreate);
        }

        protected override void OnInitialized()
        {
            siteDataform = new SiteDataModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(siteDataform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("sitedata", content))
            {
                if (message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
