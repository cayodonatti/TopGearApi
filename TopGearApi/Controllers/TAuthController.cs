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
    public class TAuthController<T> : BaseController<T> where T : class, IEntity
    {
        [HttpPost]
        public Response<IEnumerable<T>> Get([FromBody] BaseRequest req)
        {
            return new Response<IEnumerable<T>>
            {
                Sucesso = true,
                Dados = TopGearDA<T>.Get()
            };
        }

        // GET: api/T/PorId/5
        [ActionName("PorId")]
        [HttpPost]
        public Response<T> Get(int id, [FromBody] BaseRequest req)
        {
            if (IsValid(req.Token))
            {
                return new Response<T>
                {
                    Sucesso = true,
                    Dados = TopGearDA<T>.Get(id)
                };
            }
            else
            {
                return new Response<T>
                {
                    Sucesso = false,
                    Mensagem = "Token Inválido!"
                };
            }
        }
    }
}
