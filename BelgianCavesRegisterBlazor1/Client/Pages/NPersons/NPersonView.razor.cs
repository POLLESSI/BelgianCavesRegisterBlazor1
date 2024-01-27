//using Microsoft.AspNetCore.Components;
//using Newtonsoft.Json;
//using Microsoft.AspNetCore.SignalR.Client;
//using System.Runtime.ExceptionServices;
//using BelgianCavesRegisterBlazor1.Client.Models;

//namespace BelgianCavesRegisterBlazor1.Client.Pages.NPerson
//{
//    public partial class NPersonView
//    {
//        [Inject]
//        public HttpClient Client { get; set; }
//        public HubConnection hubConnection { get; set; }
//        public List<NPersonModel> NPersonList { get; set; }
//        public int SelectedId { get; set; }

//        protected override async Task OnInitializedAsync()
//        {
//            NPersonList = new List<NPersonModel>();
//            await GetNPerson();
//            hubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7044/npersonhub")).Build();
//        }

//        private void ClickInfo(int nPerson_Id)
//        {
//            SelectedId = nPerson_Id;
//        }

//        private async Task GetNPerson()
//        {
//            using(HttpResponseMessage message = await Client.GetAsync("nperson"))
//            {
//                if (message.IsSuccessStatusCode)
//                {
//                    string json = await message.Content.ReadAsStringAsync();
//                    JsonConvert.DeserializeObject<NPersonModel>(json);
//                }
//            }
//        }
//    }
//}
