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
    public class LocacaoController : TController<Locacao>
    {
        [HttpPost]
        // POST: api/Locacao
        public override Response<int> Post([FromBody]Request<Locacao> value)
        {
            if (value != null && IsValid(value.Token))
            {
                Locacao l = LocacaoDA.GetAtivaByCarro(value.Dados.CarroId);

                if (l == null)
                {
                    var Id = LocacaoDA.Insert(value.Dados);

                    return new Response<int>
                    {
                        Sucesso = true,
                        Dados = Id
                    };
                }
                else
                {
                    return new Response<int>
                    {
                        Sucesso = false,
                        Mensagem = "Já existe uma locação ativa para este veículo!"
                    };
                }
            }
            else return new Response<int> { Sucesso = false, Mensagem = "O Request está sem dados ou o Token é inválido!" };
        }

        [HttpPost]
        [ActionName("ObterLocacoes")]
        public Response<List<Locacao>> ObterLocacoes([FromBody] Request<int> req)
        {
            var locacoes = LocacaoDA.GetByCliente(req.Dados);
            return new Response<List<Locacao>>
            {
                Sucesso = true,
                Dados = locacoes
            };
        }
    }
}
