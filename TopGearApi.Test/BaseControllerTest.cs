using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopGearApi.Test.Utils;
using TopGearApi.Domain.Models;
using System.Collections.Generic;

namespace TopGearApi.Test
{
    public abstract class BaseControllerTest<T> where T : class, IEntity
    {
        protected string path;

        [TestMethod]
        public void Get()
        {
            var response = TopGearApi<List<T>>.Get(path);
            Assert.IsTrue(response.Sucesso);
            Assert.IsTrue(response.Dados.Count > 0);

            var objeto = response.Dados[0];

            var response2 = TopGearApi<T>.Get($"{path}/PorId/{objeto.Id}");
            Assert.IsTrue(response2.Sucesso);
            Assert.IsTrue(response2.Dados.Id == objeto.Id);
        }
    }
}
