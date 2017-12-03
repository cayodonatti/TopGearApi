using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Access;
using TopGearApi.Domain.Models;
using TopGearApi.Models;

namespace TopGearApi.Test
{
    [TestClass]
    public class LocacaoControllerTest : BaseControllerTest<Locacao>
    {
        public LocacaoControllerTest()
        {
            this.path = "locacao";
        }

        [TestMethod]
        public void Fluxo_Locacao()
        {
            var req = new RequestCarrosDisponiveis
            {
                Inicial = new DateTime(1973, 10, 01),
                Final = new DateTime(1973, 10, 15),
                Token = TopGearApi<Carro>.GetToken()
            };

            List<Carro> carros = CarroApi.ObterDisponiveis(req).Dados;
            Locacao l = new Locacao
            {
                CarroId = carros.First().Id,
                ClienteId = TopGearApi<List<Cliente>>.GetAuth("cliente").Dados.First().Id,
                Agencia_EntregaId = TopGearApi<List<Agencia>>.Get("agencia").Dados.First().Id,
                Agencia_RetiradaId = TopGearApi<List<Agencia>>.Get("agencia").Dados.First().Id,
                Retirada = new DateTime(2017, 10, 15),
                Entrega = new DateTime(2017, 10, 20)
            };

            var Id = this.Post(l);

            Assert.IsFalse(l.CarroId == carros.Last().Id);
            l.CarroId = carros.Last().Id;
            this.Update(Id, l);

            var canceled = TopGearApi<Locacao>.PostId(Id, "Locacao/CancelarLocacao");
            Assert.IsTrue(canceled.Sucesso);

            var loc = TopGearApi<Locacao>.Get(Id, "locacao");
            Assert.IsTrue(loc.Sucesso);
            Assert.IsTrue(loc.Dados.Cancelada);

            this.Delete(Id);
        }
    }
}
