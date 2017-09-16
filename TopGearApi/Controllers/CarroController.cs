using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopGearApi.DAO;
using TopGearApi.Models;

namespace TopGearApi.Controllers
{
    public class CarroController : ApiController
    {
        public CarroDao _dao;

        // GET: api/Carro
        public IEnumerable<Carro> Get()
        {
            return _dao.Obter();
        }

        // GET: api/Carro/5
        public Carro Get(int id)
        {
            return _dao.Obter(id);
        }

        // POST: api/Carro
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Carro/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Carro/5
        public void Delete(int id)
        {
        }
    }
}
