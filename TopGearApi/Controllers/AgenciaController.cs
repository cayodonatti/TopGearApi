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
    [AllowAnonymous]
    public class AgenciaController : TController<Agencia>
    {
        [HttpGet]
        [ActionName("ObterPorSigla")]
        public Response<Agencia> GetByItem(string sigla)
        {
            return new Response<Agencia>
            {
                Sucesso = true,
                Dados = AgenciaDA.GetBySigla(sigla)
            };
        }
    }
}
