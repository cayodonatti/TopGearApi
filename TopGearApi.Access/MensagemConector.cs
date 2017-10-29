using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.Access
{
    public class MensagemConector
    {
        public void Send(string message)
        {
            TopGearApi<Mensagem>.Post(new Mensagem { Origem = 0, Texto = message }, "mensagem");
        }
    }
}
