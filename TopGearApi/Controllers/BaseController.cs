﻿using System;
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
    public class BaseController<T> : ApiController where T : class, IEntity
    {
        // POST: api/T
        public virtual Response<int> Post([FromBody]Request<T> value)
        {
            if (value != null && IsValid(value.Token))
            {
                var Id = TopGearDA<T>.Insert(value.Dados);
                return new Response<int> { Sucesso = true, Dados = Id };
            }
            else return new Response<int> { Sucesso = false, Mensagem = "O Request está sem dados ou o Token é inválido!" };
        }

        // PUT: api/T/5
        public Response<T> Put(int id, [FromBody]Request<T> value)
        {
            if (value != null && IsValid(value.Token))
            {
                value.Dados.Id = id;
                TopGearDA<T>.Update(value.Dados);
                return new Response<T> { Sucesso = true };
            }
            else return new Response<T> { Sucesso = false, Mensagem = "O Request está sem dados ou o Token é inválido!" };
        }

        // DELETE: api/T
        public Response<T> Delete([FromBody]Request<int> value)
        {
            if (value != null && IsValid(value.Token))
            {
                try
                {
                    TopGearDA<T>.Delete(value.Dados);
                }
                catch (Exception ex)
                {
                    return new Response<T> { Sucesso = false, Mensagem = ex.Message };
                }
                return new Response<T> { Sucesso = true };
            }
            else return new Response<T> { Sucesso = false, Mensagem = "O Request está sem dados ou o Token é inválido!" };
        }

        [NonAction]
        protected bool IsValid(string token)
        {
            return TopGearDA<T>.CheckToken(token);
        }
    }
}
