using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Administrators
{
    public partial class NPersonCreate
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NPersonModel? npersonform { get; set; }
        [Parameter]
        public object? ValueFromNPersonCreate { get; set; }
        public EventCallback<object> EventCreateNPerson { get; set; }

        protected void ExecuteEventCreateNPerson()
        {
            EventCreateNPerson.InvokeAsync(ValueFromNPersonCreate);
        }

        protected override void OnInitialized()
        {
            npersonform = new NPersonModel();
        }

        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(npersonform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nperson", content))
            {
                if (message.IsSuccessStatusCode)
                {
                    Console.WriteLine(message.Content);
                }
            }
        }
    }
}