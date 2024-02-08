﻿using BelgianCavesRegisterBlazor1.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgianCavesRegisterBlazor1.Client.Pages.Administrators
{
    public partial class LambdaDataCreate
    {
        [Inject]

        public HttpClient Client { get; set; }

        public LambdaDataModel? lambdaDataform { get; set; }

        [Parameter]
        public object? ValueFromLambdaDataCreate { get; set; }
        public EventCallback<object> EventCreateLambdaData { get; set; }
        protected void ExecuteEventCreateLambdaData()
        {
            EventCreateLambdaData.InvokeAsync(ValueFromLambdaDataCreate);
        }

        protected override void OnInitialized()
        {
            lambdaDataform = new LambdaDataModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(lambdaDataform);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("lambdadata", content))
            {
                if (message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}