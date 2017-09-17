using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TopGearApi.Domain.Models
{
    public class Carro : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        [StringLength(7)]
        [Index(IsUnique = true)]
        public string Placa { get; set; }
        [Required]
        public int Ano { get; set; }

        public bool EmManutencao { get; set; } = false;

        public virtual Agencia Agencia { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}