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
    public class TController<T> : ApiController where T : class, IEntity
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

        // GET: api/T/5
        public Response<T> Get(int id)
        {
            return new Response<T>
            {
                Sucesso = true,
                Dados = TopGearDA<T>.Get(id)
            };
        }

        // POST: api/T
        public Response<T> Post([FromBody]T value)
        {
            TopGearDA<T>.Insert(value);
            return new Response<T> { Sucesso = true };
        }

        // PUT: api/T/5
        public Response<T> Put(int id, [FromBody]T value)
        {
            value.Id = id;
            TopGearDA<T>.Update(value);
            return new Response<T> { Sucesso = true };
        }

        // DELETE: api/T/5
        public Response<T> Delete(int id)
        {
            TopGearDA<T>.Delete(id);
            return new Response<T> { Sucesso = true };
        }
    }
}
