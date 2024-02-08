using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NUsers
{
    public partial class NUserDetail
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserModel? CurrentNUser { get; set; }
        [Parameter]
        public Guid NUser_Id { get; set; }
        //[Parameter]
        //public object? ValueFromNUserDetail { get; set; }
        //[Parameter]
        //public EventCallback<object> EventDetailNUser { get; set; }

        //protected void ExecuteEventCreateNUser()
        //{
        //    EventDetailNUser.InvokeAsync(ValueFromNUserDetail);
        //}

        protected override async Task OnParametersSetAsync()
        {
            await GetNUser();
        }
        private async Task GetNUser()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nuser" + NUser_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentNUser = JsonConvert.DeserializeObject<NUserModel>(json);
                }
            }
        }
    }
}
