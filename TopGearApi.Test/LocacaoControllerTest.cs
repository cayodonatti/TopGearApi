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
    public class LocacaoControllerTest : BaseControllerTest<Locacao>
    {
        public LocacaoControllerTest()
        {
            this.path = "locacao";
        }

        [TestMethod]
        public void Post_Locacao()
        {
            //var req = new RequestCarrosDisponiveis
            //{
            //    Inicial = new DateTime(2017, 10, 01),
            //    Final = new DateTime(2017, 10, 15),
            //    Token = TopGearApi<Carro>.GetToken()
            //};

            //List<Carro> carros = CarroApi.ObterDisponiveis(req).Dados;
            //Locacao l = new Locacao
            //{
            //    CarroId = carros.First().Id,
            //    ClienteId = TopGearApi<List<Cliente>>.Get("cliente").Dados.First().Id,
            //    Agencia_EntregaId = TopGearApi<List<Agencia>>.Get("agencia").Dados.First().Id,
            //    Agencia_RetiradaId = TopGearApi<List<Agencia>>.Get("agencia").Dados.First().Id,
            //    Retirada = new DateTime(2017, 10, 15),
            //    Entrega = new DateTime(2017, 10, 20)
            //};

            //var Id = this.Post(l);

            //Assert.IsFalse(l.CarroId == carros.Last().Id);
            //l.CarroId = carros.Last().Id;
            //this.Update(Id, l);

            //this.Delete(Id);
        }
    }
}
