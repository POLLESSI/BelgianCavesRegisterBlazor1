using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Administrators
{
    public partial class NUserCreate
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserModel? nUserform { get; set; }
        [Parameter]
        public object? ValueFromNUserCreate { get; set; }
        [Parameter]
        public EventCallback<object> EventCreateNUser { get; set; }

        protected void ExecuteEventCreateNUser()
        {
            EventCreateNUser.InvokeAsync(ValueFromNUserCreate);
        }

        protected override void OnInitialized()
        {
            nUserform = new NUserModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(nUserform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nuser", content))
            {
                if (message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
