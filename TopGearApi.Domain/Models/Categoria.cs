using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopGearApi.Domain.Models
{
    public class Categoria : IEntity
    {
        public int Id { get; set; }

        [Required]
        public double Preco { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Itens { get; set; }

        public virtual ICollection<Carro> Carros { get; set; }
    }
}