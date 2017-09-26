using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopGearApi.DataAccess;
using TopGearApi.Domain.Models;
using TopGearApi.Models;

namespace TopGearApi.Controllers
{
    public class CarroController : TController<Carro>
    {
        private CarroDA DA = new CarroDA();
        
        [HttpGet]
        public IEnumerable<Carro> GetByItem(int id)
        {
            return DA.GetByItem(id);
        }

        [HttpGet]
        public IEnumerable<Carro> GetDisponiveis()
        {
            return DA.GetDisponiveis();
        }

        [HttpGet]
        public IEnumerable<Carro> GetDisponiveisByAgencia(int id)
        {
            return DA.GetDisponiveisByAgencia(id);
        }
    }
}
