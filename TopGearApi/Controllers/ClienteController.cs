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
    public class ClienteController : TController<Cliente>
    {
        [HttpPost]
        [ActionName("Login")]
        public Response<Cliente> Login([FromBody] LoginRequest req)
        {
            if (req.CPF != null && req.CPF != null && IsValid(req.Token))
            {
                var cli = ClienteDA.Login(req.CPF, req.Senha);

                if (cli != null)
                {
                    return new Response<Cliente>
                    {
                        Dados = cli,
                        Sucesso = true
                    };
                }
                else
                {
                    return new Response<Cliente>
                    {
                        Sucesso = false,
                        Mensagem = "Cliente não encontrado ou login e senha não batem"
                    };
                }
            }
            else
            {
                return new Response<Cliente>
                {
                    Sucesso = false,
                    Mensagem = "Requisição Inválida"
                };
            }
        }
    }
}
