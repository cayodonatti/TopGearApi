using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopGearApi.Domain.Models;
using TopGearApi.Models;

namespace TopGearApi.Controllers
{
    public class CarroController : ApiController
    {
        // GET: api/Carro
        public Response<IEnumerable<Carro>> Get()
        {
            return new Response<IEnumerable<Carro>>
            {
                Sucesso = true,
                Dados = new List<Carro>{
                    new Carro
                    {
                        Id = 1,
                        Marca = "Chevrolet",
                        Modelo = "Corsa",
                        Placa = "MST1231",
                        Ano = 2017
                    },
                    new Carro
                    {
                        Id = 2,
                        Marca = "Chevrolet",
                        Modelo = "Camaro",
                        Placa = "ASD1262",
                        Ano = 2015
                    },
                    new Carro
                    {
                        Id = 3,
                        Marca = "Volkswagen",
                        Modelo = "Gol",
                        Placa = "KHJ5I53",
                        Ano = 1998
                    }
                }
            };
        }

        // GET: api/Carro/5
        public Response<Carro> Get(int id)
        {
            return new Response<Carro> {
                Dados = {
                    Id = id,
                    Marca = "Volkswagen",
                    Modelo = "Gol",
                    Placa = "KHJ5I53",
                    Ano = 1998
                }
            };
        }

        // POST: api/Carro
        public Response<Carro> Post([FromBody]Carro car)
        {
            return new Response<Carro> { Sucesso = true };
        }

        // PUT: api/Carro/5
        public Response<Carro> Put(int id, [FromBody]Carro car)
        {
            return new Response<Carro> { Sucesso = true };
        }

        // DELETE: api/Carro/5
        public Response<Carro> Delete(int id)
        {
            return new Response<Carro> { Sucesso = true };
        }
    }
}
