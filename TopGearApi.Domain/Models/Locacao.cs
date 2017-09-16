using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopGearApi.Domain.Models
{
    public class Locacao
    {
        public int Id { get; set; }

        [Required]
        public DateTime Retirada { get; set; }
        public DateTime? Entrega { get; set; }

        [Required]
        public int Id_Cliente { get; set; }
        [Required]
        public int Id_Carro { get; set; }
    }
}