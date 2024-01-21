//using BelgianCavesRegisterBlazor1.Client.Models;
//using Microsoft.AspNetCore.Components;
//using Newtonsoft.Json;
//using System.Text;

//namespace BelgianCavesRegisterBlazor1.Client.Pages.NPerson
//{
//    public partial class NPersonCreate
//    {
//        [Inject]
//        public HttpClient Client { get; set; }
//        public NPersonModel? nPersonform { get; set; }
//        protected override void OnInitialized()
//        {
//            nPersonform = new NPersonModel();
//        }
//        public async Task submit()
//        {
//            string json = JsonConvert.SerializeObject(nPersonform);
//            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
//            using (HttpResponseMessage message = await Client.PostAsync("nperson", content))
//            {
//                if (message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
//            }
//        }
//    }
//}
