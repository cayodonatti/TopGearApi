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
            if (req.Inicial != DateTime.MinValue && req.Final != DateTime.MinValue && IsValid(req.Token))
            {
                return new Response<IEnumerable<Carro>>
                {
                    Sucesso = true,
                    Dados = CarroDA.GetDisponiveis(req.Inicial, req.Final, req.ItemId)
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

        [HttpPost]
        [ActionName("ObterDisponiveisCategorias")]
        public CarrosComPrecoResponse ObterDisponiveisCategorias([FromBody] RequestCarrosDisponiveis req)
        {
            if (req.Inicial != DateTime.MinValue && req.Final != DateTime.MinValue && IsValid(req.Token))
            {
                var carros = CarroDA.GetDisponiveis(req.Inicial, req.Final, req.ItemId);
                var categorias = TopGearDA<Categoria>.Get();

                return new CarrosComPrecoResponse
                {
                    Sucesso = true,
                    Dados = carros,
                    Categorias = categorias
                };
            }
            else
            {
                return new CarrosComPrecoResponse
                {
                    Sucesso = false,
                    Mensagem = "Requisição Inválida"
                };
            }
        }
    }
}
