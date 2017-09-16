using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;
using TopGearApi.Models;

namespace TopGearApi.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://topgearapi.azurewebsites.net/api/")
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("carro").Result;
            if (response.IsSuccessStatusCode)
            {
                var list = response.Content.ReadAsAsync<Response<IEnumerable<Carro>>>().Result;

                foreach (var car in list.Dados)
                {
                    System.Console.WriteLine(car.Marca);
                }

                System.Console.ReadLine();
            }

        }
    }
}
