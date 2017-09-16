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
    public class CategoriaController : ApiController
    {
        // GET: api/Categoria
        public Response<IEnumerable<Categoria>> Get()
        {
            return new Response<IEnumerable<Categoria>>
            {
                Sucesso = true,
                Dados = new List<Categoria>
                {
                    new Categoria
                    {
                        Descricao = "Luxo",
                        Preco = 250.15,
                        Itens = "Ar Condicionado, Vidro Elétrico, Câmbio Automático, Direção Hidráulica"
                    },
                    new Categoria
                    {
                        Descricao = "Esporte",
                        Preco = 140.57,
                        Itens = "Ar Condicionado, Vidro Elétrico, Direção Hidráulica"
                    },
                    new Categoria
                    {
                        Descricao = "Popular",
                        Preco = 99.00,
                        Itens = "Direção Hidráulica"
                    }
                }
            };
        }

        // GET: api/Categoria/5
        public Response<Categoria> Get(int id)
        {
            return new Response<Categoria>
            {
                Sucesso = true,
                Dados = new Categoria
                {
                    Id = id,
                    Descricao = "Popular",
                    Preco = 99.00,
                    Itens = "Direção Hidráulica"
                }
            };
        }

        // POST: api/Categoria
        public Response<Categoria> Post([FromBody]Categoria value)
        {
            return new Response<Categoria> { Sucesso = true };
        }

        // PUT: api/Categoria/5
        public Response<Categoria> Put(int id, [FromBody]Categoria value)
        {
            return new Response<Categoria> { Sucesso = true };
        }

        // DELETE: api/Categoria/5
        public Response<Categoria> Delete(int id)
        {
            return new Response<Categoria> { Sucesso = true };
        }
    }
}
