using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopGearApi.Models;

namespace TopGearApi.Controllers
{
    public class AgenciaController : ApiController
    {
        // GET: api/Agencia
        public Response<IEnumerable<Agencia>> Get()
        {
            return new Response<IEnumerable<Agencia>>
            {
                Sucesso = true,
                Dados = new List<Agencia>{
                    new Agencia
                    {
                        Rua = "Rua Agenor Silva",
                        Numero = 150,
                        Bairro = "Manguinhos",
                        Cidade = "Serra",
                        Estado = "ES"
                    },
                    new Agencia
                    {
                        Rua = "Avenida Xablau",
                        Numero = 980,
                        Bairro = "Ibes",
                        Cidade = "Vila Velha",
                        Estado = "ES"
                    }
                }
            };
        }

        // GET: api/Agencia/5
        public Response<Agencia> Get(int id)
        {
            return new Response<Agencia>
            {
                Sucesso = true,
                Dados = new Agencia
                {
                    Id = id,
                    Rua = "Rua Agenor Silva",
                    Numero = 150,
                    Bairro = "Manguinhos",
                    Cidade = "Serra",
                    Estado = "ES"
                }
            };
        }

        // POST: api/Agencia
        public Response<Agencia> Post([FromBody]Agencia value)
        {
            return new Response<Agencia> { Sucesso = true };
        }

        // PUT: api/Agencia/5
        public Response<Agencia> Put(int id, [FromBody]Agencia value)
        {
            return new Response<Agencia> { Sucesso = true };
        }

        // DELETE: api/Agencia/5
        public Response<Agencia> Delete(int id)
        {
            return new Response<Agencia> { Sucesso = true };
        }
    }
}
