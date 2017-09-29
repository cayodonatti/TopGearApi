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
    public class CarroController : TController<Carro>
    {
        
        [HttpGet]
        [ActionName("ObterPorItem")]
        public Response<IEnumerable<Carro>> GetByItem(int id)
        {
            return new Response<IEnumerable<Carro>>
            {
                Sucesso = true,
                Dados = CarroDA.GetByItem(id)
            };
        }

        [HttpGet]
        [ActionName("ObterDisponiveis")]
        public Response<IEnumerable<Carro>> GetDisponiveis()
        {
            return new Response<IEnumerable<Carro>>
            {
                Sucesso = true,
                Dados = CarroDA.GetDisponiveis()
            };
        }

        [HttpGet]
        [ActionName("ObterDisponiveisPorAgencia")]
        public Response<IEnumerable<Carro>> GetDisponiveisByAgencia(int id)
        {
            return new Response<IEnumerable<Carro>>
            {
                Sucesso = true,
                Dados = CarroDA.GetDisponiveisByAgencia(id)
            };
        }
    }
}
