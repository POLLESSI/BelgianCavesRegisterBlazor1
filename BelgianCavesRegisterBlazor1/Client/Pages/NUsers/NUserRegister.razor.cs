using BelgianCavesRegisterBlazor1.Client.Models;
using BelgianCavesRegisterBlazor1.Client.Pages.NUsers;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.NUsers
{
    public partial class NUserRegister
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserRegisterModel? nuserregisterform { get; set; }
        protected override void OnInitialized()
        {
            nuserregisterform = new NUserRegisterModel();
        }
        private string nPersonRegisterPageLink = "/npersons/npersonregister";
            
        public async Task submit()
        {
            // Logique de soumission du formulaire
            string json = JsonConvert.SerializeObject(nuserregisterform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nuser", content))
            {
                if (message.IsSuccessStatusCode)
                {
                    Console.WriteLine(message.Content);
                }
            }
            // Redirection vers une autre page après la soumission réussie
            NavigationManager.NavigateTo(nPersonRegisterPageLink);
        }
    }
}
