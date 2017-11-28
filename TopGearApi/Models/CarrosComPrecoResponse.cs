using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopGearApi.Domain.Models;

namespace TopGearApi.Models
{
    public class CarrosComPrecoResponse : Response<IEnumerable<Carro>>
    {
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}