using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Administrators
{
    public partial class NOwnerCreate
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NOwnerModel? nOwnerform { get; set; }
        public object? ValueFromNOwnerCreate { get; set; }
        [Parameter]

        public EventCallback<object> EventCreateNOwner { get; set; }

        protected override void OnInitialized()
        {
            nOwnerform = new NOwnerModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(nOwnerform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nowner", content))
            {
                if (message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
