using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;
using TopGearApi.Models;
using TopGearApi.Test.Utils;

namespace TopGearApi.Test
{
    [TestClass]
    public class CarroControllerTest : BaseControllerTest<Carro>
    {
        public CarroControllerTest()
        {
            this.path = "carro";
        }

        [TestMethod]
        public void Post_Carro()
        {
            Carro c = new Carro
            {
                AgenciaId = TopGearApi<List<Agencia>>.Get("agencia").Dados.First().Id,
                Marca = "Teste",
                Ano = 2017,
                Modelo = "Teste",
                Placa = "TST1234",
                CategoriaId = TopGearApi<List<Categoria>>.Get("categoria").Dados.First().Id,
                UrlImagem = "fake12312"
            };

            var Id = this.Post(c);

            c.Marca = "Teste 2";

            this.Update(Id, c);

            this.Delete(Id);
        }

        [TestMethod]
        public void ObterDisponiveis()
        {
            var req = new RequestCarrosDisponiveis
            {
                Inicial = new DateTime(2017, 10, 01),
                Final = new DateTime(2017, 10, 15),
                Token = TopGearApi<Carro>.GetToken()
            };

            var ret = CarroApi.ObterDisponiveis(req);
            Assert.IsTrue(ret.Sucesso);
            Assert.IsNotNull(ret.Dados);
        }
    }
}
