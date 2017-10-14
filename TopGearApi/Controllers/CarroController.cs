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

        [HttpPost]
        [ActionName("ObterDisponiveis")]
        public Response<IEnumerable<Carro>> GetDisponiveis([FromBody] RequestCarrosDisponiveis req)
        {
            if (ModelState.IsValid)
            {
                return new Response<IEnumerable<Carro>>
                {
                    Sucesso = true,
                    Dados = CarroDA.GetDisponiveis(req.Inicial, req.Final, req.AgenciaId)
                };
            }
            else
            {
                return new Response<IEnumerable<Carro>>
                {
                    Sucesso = false,
                    Mensagem = "Requisição Inválida"
                };
            }
        }
    }
}
