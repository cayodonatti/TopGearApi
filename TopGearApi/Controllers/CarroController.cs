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
        private CarroDA DA = new CarroDA();
        
        [HttpGet]
        [ActionName("ObterPorItem")]
        public Response<IEnumerable<Carro>> GetByItem(int id)
        {
            return new Response<IEnumerable<Carro>>
            {
                Sucesso = true,
                Dados = DA.GetByItem(id)
            };
        }

        [HttpGet]
        [ActionName("ObterDisponiveis")]
        public Response<IEnumerable<Carro>> GetDisponiveis()
        {
            return new Response<IEnumerable<Carro>>
            {
                Sucesso = true,
                Dados = DA.GetDisponiveis()
            };
        }

        [HttpGet]
        [ActionName("ObterDisponiveisPorAgencia")]
        public Response<IEnumerable<Carro>> GetDisponiveisByAgencia(int id)
        {
            return new Response<IEnumerable<Carro>>
            {
                Sucesso = true,
                Dados = DA.GetDisponiveisByAgencia(id)
            };
        }
    }
}
