﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;
using TopGearApi.Models;

namespace TopGearApi.Access
{
    public class CarroApi : TopGearApi<Carro>
    {
        public static Response<List<Carro>> ObterDisponiveis(RequestCarrosDisponiveis req)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("carro/obterdisponiveis", req).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Response<List<Carro>>>().Result;
                return result;
            }
            else return new Response<List<Carro>> { Sucesso = false };
        }
    }
}
