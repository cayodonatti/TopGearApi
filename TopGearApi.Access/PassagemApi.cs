using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Access.PassagemModels;

namespace TopGearApi.Access
{
    public static class PassagemApi
    {
        private static readonly string urlBase = "http://viniciuszorzanelli.com/Source/Slim/api.php/";

        public static List<Voo> GetTodosVoos()
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(urlBase + "getTodosVoos")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

            HttpResponseMessage response = client.GetAsync("").Result;
            var teste = response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;

                var voos = JsonConvert.DeserializeObject<List<Voo>>(json);

                return voos;
            }
            else return new List<Voo>();
        }

        public static List<Voo> GetVoos(DateTime data, string aeroporto, string cidade)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(urlBase + $"getVoos/{data.ToString("aaaa-mm-dd")}/{aeroporto}/{cidade}")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

            HttpResponseMessage response = client.GetAsync("").Result;
            var teste = response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;

                var voos = JsonConvert.DeserializeObject<List<Voo>>(json);

                return voos;
            }
            else return new List<Voo>();
        }

        public static int InserirCompra(string Cartao, string Cpf)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(urlBase + $"inserirCompra/{Cartao}/{Cpf}")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;

                var id = JsonConvert.DeserializeObject<int>(json);

                return id;
            }
            else return -1;
        }

        public static int InserirTicket(int idCompra, int idVoo, string Nome, string Cartao, string Cpf, DateTime Nascimento)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(urlBase + $"inserirTicket/{idCompra}/{idVoo}/{2}/{Nome}/{Cpf}/{Nascimento.ToShortDateString()}")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;

                var id = JsonConvert.DeserializeObject<int>(json);

                return id;
            }
            else return -1;
        }
    }

}
