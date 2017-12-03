using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Access;

namespace TopGearApi.Test
{
    [TestClass]
    public class PassagemApiTest
    {
        [TestMethod]
        public void ObterTodosVoos()
        {
            var voos = PassagemApi.GetTodosVoos();

            Assert.IsNotNull(voos);
        }

        
        public void ObterVoos()
        {
            var todos = PassagemApi.GetTodosVoos();

            Assert.IsNotNull(todos);

            var voo = todos.FirstOrDefault();

            var voos = PassagemApi.GetVoos(new DateTime(2017, 12, 10), voo.aeroporto_partida, voo.aeroporto_destino);

            Assert.IsNotNull(voos);
        }

        [TestMethod]
        public void InserirCompra()
        {
            var todos = PassagemApi.GetTodosVoos();

            Assert.IsNotNull(todos);

            var voo = todos.FirstOrDefault();

            var idCompra = PassagemApi.InserirCompra("1234567812345678", "32132132132");

            Assert.IsTrue(idCompra > 0);

            var idTicket = PassagemApi.InserirTicket(idCompra, voo.idVoo, "Gerson", 
                                                        "1234567812345678", "32132132132", 
                                                        new DateTime(1990, 12, 10));

            Assert.IsTrue(idCompra > 0);
        }
    }
}
