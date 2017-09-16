using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopGearApi.Models
{
    public class Carro
    {
        public int Id { get; set; }

        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public int Ano { get; set; }

        public bool EmManutencao { get; set; } = false;
    }
}