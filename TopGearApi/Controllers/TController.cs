using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopGearApi.DataAccess;
using TopGearApi.Domain.Models;
using TopGearApi.Models;

namespace TopGearApi.Controllers
{
    public abstract class TController<T> : ApiController where T : class, IEntity
    {
        // GET: api/T
        public Response<IEnumerable<T>> Get()
        {
            return new Response<IEnumerable<T>>
            {
                Sucesso = true,
                Dados = TopGearDA<T>.Get()
            };
        }

        // GET: api/T/PorId/5
        [ActionName("PorId")]
        public Response<T> Get(int id)
        {
            return new Response<T>
            {
                Sucesso = true,
                Dados = TopGearDA<T>.Get(id)
            };
        }

        // POST: api/T
        public Response<T> Post([FromBody]Request<T> value)
        {
            if (IsValid(value.Token))
            {
                TopGearDA<T>.Insert(value.Dados);
                return new Response<T> { Sucesso = true };
            } else return new Response<T> { Sucesso = false, Mensagem = "Token Inválido!" };
        }

        // PUT: api/T/5
        public Response<T> Put(int id, [FromBody]Request<T> value)
        {
            if (IsValid(value.Token))
            {
                value.Dados.Id = id;
                TopGearDA<T>.Update(value.Dados);
                return new Response<T> { Sucesso = true };
            } else return new Response<T> { Sucesso = false, Mensagem = "Token Inválido!" };
        }

        // DELETE: api/T
        public Response<T> Delete([FromBody]Request<int> value)
        {
            if (IsValid(value.Token))
            {
                TopGearDA<T>.Delete(value.Dados);
                return new Response<T> { Sucesso = true };
            } else return new Response<T> { Sucesso = false, Mensagem = "Token Inválido!" };
        }

        [NonAction]
        protected bool IsValid(string token)
        {
            return TopGearDA<T>.CheckToken(token);
        }
    }
}
