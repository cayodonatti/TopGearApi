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
    public class LocacaoController : TController<Locacao>
    {
        public new Response<Locacao> Post([FromBody]Request<Locacao> value)
        {
            if (value != null && IsValid(value.Token))
            {
                Locacao l = LocacaoDA.GetAtivaByCarro(value.Dados.CarroId);

                if (l == null)
                {
                    LocacaoDA.Insert(value.Dados);

                    return new Response<Locacao>
                    {
                        Sucesso = true
                    };
                }
                else
                {
                    return new Response<Locacao>
                    {
                        Sucesso = false,
                        Mensagem = "Já existe uma locação ativa para este veículo!"
                    };
                }
            }
            else return new Response<Locacao> { Sucesso = false, Mensagem = "O Request está sem dados ou o Token é inválido!" };
        }
    }
}
