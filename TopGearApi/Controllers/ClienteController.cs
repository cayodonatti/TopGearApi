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
    public class ClienteController : ApiController
    {
        // GET: api/Cliente
        public Response<IEnumerable<Cliente>> Get()
        {
            return new Response<IEnumerable<Cliente>>
            {
                Sucesso = true,
                Dados = new List<Cliente>{
                    new Cliente
                    {
                        Nome = "Cayo Donatti",
                        CPF = "00000000272",
                        Endereco = "Rua X",
                        Telefone = "2733263638",
                        Cartao = "8888777766665555"
                    },
                    new Cliente
                    {
                        Nome = "Ricardo Sabaini",
                        CPF = "00000000191",
                        Endereco = "Rua Y",
                        Telefone = "2764654852",
                        Cartao = "1111222233334444"
                    }
                }
            };
        }

        // GET: api/Cliente/5
        public Response<Cliente> Get(int id)
        {
            return new Response<Cliente> {
                Sucesso = true,
                Dados = new Cliente
                {
                    Id = id,
                    Nome = "Cayo Donatti",
                    CPF = "00000000272",
                    Endereco = "Rua X",
                    Telefone = "2733263638",
                    Cartao = "8888777766665555"
                }
            };
        }

        // POST: api/Cliente
        public Response<Cliente> Post([FromBody]Cliente value)
        {
            return new Response<Cliente> { Sucesso = true };
        }

        // PUT: api/Cliente/5
        public Response<Cliente> Put(int id, [FromBody]Cliente value)
        {
            return new Response<Cliente> { Sucesso = true };
        }

        // DELETE: api/Cliente/5
        public Response<Cliente> Delete(int id)
        {
            return new Response<Cliente> { Sucesso = true };
        }
    }
}
