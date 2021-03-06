﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Models;

namespace TopGearApi.Access
{
    public class TopGearApi<T> : GenericApi
    {
        protected TopGearApi() { }

        public static Response<T> Get(string relativePath)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(relativePath).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Response<T>>().Result;
            }
            else return new Response<T> { Sucesso = false };
        }

        public static Response<T> Get(int id, string relativePath)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(relativePath + "/PorId/" + id.ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Response<T>>().Result;
                return result;
            }
            else return new Response<T> { Sucesso = false };
        }

        public static Response<T> GetAuth(string relativePath)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = new StringContent(JsonConvert.SerializeObject(MakeBase()), Encoding.UTF8, "application/json"),
                Method = HttpMethod.Post,
                RequestUri = new Uri(client.BaseAddress + relativePath)
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Response<T>>().Result;
            }
            else return new Response<T> { Sucesso = false };
        }

        public static Response<T> GetAuth(int id, string relativePath)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = new StringContent(JsonConvert.SerializeObject(MakeBase()), Encoding.UTF8, "application/json"),
                Method = HttpMethod.Post,
                RequestUri = new Uri(client.BaseAddress + relativePath + "/PorId/" + id.ToString())
            };

            HttpResponseMessage response = client.SendAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Response<T>>().Result;
                return result;
            }
            else return new Response<T> { Sucesso = false };
        }

        public static Response<int> Post(T objeto, string relativePath)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync(relativePath + "/post", MakeRequest(objeto)).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Response<int>>().Result;
                return result;
            }
            else return new Response<int> { Sucesso = false };
        }

        public static Response<T> Put(T objeto, int id, string relativePath)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync(relativePath + "/Put/" + id.ToString(), 
                                                                    MakeRequest(objeto)).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Response<T>>().Result;
                return result;
            }
            else return new Response<T> { Sucesso = false };
        }

        public static Response<T> Delete(int id, string relativePath)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = new StringContent(JsonConvert.SerializeObject(TopGearApi<int>.MakeRequest(id)), Encoding.UTF8, "application/json"),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(client.BaseAddress + relativePath + "/Delete")
            };

            HttpResponseMessage response = client.SendAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Response<T>>().Result;
                return result;
            }
            else return new Response<T> { Sucesso = false };
        }

        public static Response<T> PostId(int objeto, string relativePath)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync(relativePath, TopGearApi<int>.MakeRequest(objeto)).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Response<T>>().Result;
                return result;
            }
            else return new Response<T> { Sucesso = false };
        }

        protected static Request<T> MakeRequest(T dados)
        {
            return new Request<T> { Dados = dados, Token = Token };
        }

        protected static BaseRequest MakeBase()
        {
            return new BaseRequest
            {
                Token = Token
            };
        }

        public static string GetToken()
        {
            return Token;
        }
    }
}