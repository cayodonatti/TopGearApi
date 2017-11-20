using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Access;
using TopGearApi.Domain.Models;

namespace TopGearApi.Test
{
    [TestClass]
    public class ClienteControllerTest : BaseControllerTest<Cliente>
    {
        public ClienteControllerTest()
        {
            this.path = "cliente";
        }

        [TestMethod]
        public new void Get()
        {
            var response = TopGearApi<List<Cliente>>.GetAuth(path);
            Assert.IsTrue(response.Sucesso);
            Assert.IsTrue(response.Dados.Count > 0);

            var objeto = response.Dados[0];

            var response2 = TopGearApi<Cliente>.GetAuth(objeto.Id, path);
            Assert.IsTrue(response2.Sucesso);
            Assert.IsTrue(response2.Dados.Id == objeto.Id);
        }

        [TestMethod]
        public void Fluxo_Cliente()
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
