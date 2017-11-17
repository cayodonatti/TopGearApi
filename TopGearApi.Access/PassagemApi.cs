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
    public class PassagemApi
    {
        private static string urlBase = "http://viniciuszorzanelli.com/Source/Slim/api.php/";

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

        public static bool PostCliente(string nome, string cpf, DateTime dataNascimento)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(urlBase + $"inserirPassageiro/{nome}/{cpf}/{dataNascimento.ToString()}")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

            HttpResponseMessage response = client.GetAsync("").Result;
            var teste = response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;
        }

        public static bool PostCompra(int idCliente, string numCartao)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(urlBase + $"inserirCompra/{numCartao}/{idCliente}")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

            HttpResponseMessage response = client.GetAsync("").Result;
            var teste = response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;
        }

        public static bool PostTicket(int idCompra, int idVoo, int numeroAssento, int idPassageiro)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(urlBase + $"inserirTicket/{idCompra}/{idVoo}/{numeroAssento}/{idPassageiro}")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

            HttpResponseMessage response = client.GetAsync("").Result;
            var teste = response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;
        }
    }

}
