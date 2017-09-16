using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopGearApi.Api.Models
{
    public class CarroModel
    {
        public int Id { get; set; }

        public int ModeloId { get; set; }
        public string ModeloDescricao { get; set; }

        public int CategoriaId { get; set; }
        public int LocalizacaoId { get; set; }

        public bool Alocado { get; set; }
    }
}