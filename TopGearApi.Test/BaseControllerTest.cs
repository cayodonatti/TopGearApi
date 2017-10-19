using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopGearApi.Domain.Models;
using System.Collections.Generic;
using TopGearApi.Models;
using TopGearApi.Access;

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

            var response2 = TopGearApi<T>.Get(objeto.Id, path);
            Assert.IsTrue(response2.Sucesso);
            Assert.IsTrue(response2.Dados.Id == objeto.Id);
        }

        protected int Post(T obj)
        {
            var response = TopGearApi<T>.Post(obj, path);
            Assert.IsTrue(response.Sucesso);

            return response.Dados;
        }

        protected void Update(int Id, T obj)
        {
            var response = TopGearApi<T>.Put(obj, Id, path);
            Assert.IsTrue(response.Sucesso);
        }

        protected void Delete(int Id)
        {
            var response = TopGearApi<T>.Delete(Id, path);
            Assert.IsTrue(response.Sucesso);
            
            var response2 = TopGearApi<T>.Get(Id, path);
            Assert.IsTrue(response2.Sucesso);
            Assert.IsNull(response2.Dados);
        }
    }
}
