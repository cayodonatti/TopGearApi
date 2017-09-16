using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopGearApi.Api.Models;

namespace TopGearApi.Api.Controllers
{
    public class CarroController : ApiController
    {
        private List<CarroModel> Carros;

        public CarroController()
        {
            Carros = new List<CarroModel>();
            Carros.Add(new CarroModel
            {
                Id = 1,
                ModeloId = 1,
                ModeloDescricao = "Corsa",
                CategoriaId = 1,
                LocalizacaoId = 1
            });

            Carros.Add(new CarroModel
            {
                Id = 2,
                ModeloId = 2,
                ModeloDescricao = "Camaro",
                CategoriaId = 2,
                LocalizacaoId = 1
            });

            Carros.Add(new CarroModel
            {
                Id = 3,
                ModeloId = 1,
                ModeloDescricao = "Corsa",
                CategoriaId = 1,
                LocalizacaoId = 3
            });
        }
        
        // GET: api/Carro
        public IEnumerable<CarroModel> Get()
        {
            return Carros;
        }

        // GET: api/Carro/5
        public IEnumerable<CarroModel> Get(int id)
        {
            return Carros.Where(car => car.Id == id);
        }

        // POST: api/Carro
        public void Post([FromBody]CarroModel value)
        {

        }

        // PUT: api/Carro/5
        public void Put(int id, [FromBody]CarroModel value)
        {

        }

        // DELETE: api/Carro/5
        public void Delete(int id)
        {

        }
    }
}
