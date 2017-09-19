using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopGearApi.Domain.Models
{
    public class Locacao : IEntity
    {
        public int Id { get; set; }

        [Required]
        public DateTime Retirada { get; set; }
        public DateTime? Entrega { get; set; }
        
        public virtual Cliente Cliente { get; set; }
        public virtual Carro Carro { get; set; }
        public virtual Agencia Agencia_Retirada { get; set; }
        public virtual Agencia Agencia_Entrega { get; set; }
    }
}