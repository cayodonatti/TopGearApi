using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopGearApi.Domain.Models
{
    public class Agencia : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }

        public virtual ICollection<Carro> Carros_Disponiveis { get; }
    }
}