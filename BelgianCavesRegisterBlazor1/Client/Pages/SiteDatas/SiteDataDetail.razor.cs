using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgianCavesRegisterBlazor1.Client.Pages.SiteDatas
{
    public partial class SiteDataDetail
    {
        [Inject]
        public HttpClient Client { get; set; }
        public SiteDataModel? CurrentSiteData { get; set; }
        [Parameter]
        public int SiteData_Id { get; set; }
        //[Parameter]
        //public object? ValueFromSiteDataDetail { get; set; }
        //[Parameter]
        //public EventCallback<object> EventDetailSiteData { get; set; }

        //protected void ExecuteEventDetailSiteData()
        //{
        //    EventDetailSiteData.InvokeAsync(ValueFromSiteDataDetail);
        //}

        protected override async Task OnParametersSetAsync()
        {
            await GetSiteData();
        }
        private async Task GetSiteData()
        {
            using (HttpResponseMessage message = await Client.GetAsync("sitedata" + SiteData_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentSiteData = JsonConvert.DeserializeObject<SiteDataModel>(json);
                }
            }
        }
    }
}
