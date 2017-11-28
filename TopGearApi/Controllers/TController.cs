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
    [AllowAnonymous]
    public abstract class TController<T> : BaseController<T> where T : class, IEntity
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
    }
}
