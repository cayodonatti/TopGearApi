using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.Test
{
    public class ClienteControllerTest : BaseControllerTest<Cliente>
    {
        public ClienteControllerTest()
        {
            this.path = "cliente";
        }

        [TestMethod]
        public void Fluxo_Carro()
        {
            Cliente c = new Cliente
            {
                CPF = "00000000272",
                Nome = "Teste",
                Senha = "1234"
            };

            var Id = this.Post(c);

            c.Nome = "Teste2";

            this.Update(Id, c);

            this.Delete(Id);
        }
    }
}
