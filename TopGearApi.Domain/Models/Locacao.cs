using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TopGearApi.Domain.Models
{
    public class Locacao : IEntity
    {
        public int Id { get; set; }

        [Required]
        public DateTime Retirada { get; set; }
        public DateTime Entrega { get; set; }
        public DateTime? Entrega_Real { get; set; }

        public int ClienteId { get; set;}
        public int CarroId { get; set; }
        public int? Agencia_RetiradaId { get; set; }
        public int? Agencia_EntregaId { get; set; }

        public bool Finalizada { get; set; }

        [IgnoreDataMember]
        public virtual Cliente Cliente { get; set; }
        [IgnoreDataMember]
        public virtual Carro Carro { get; set; }
        [IgnoreDataMember]
        public virtual Agencia Agencia_Retirada { get; set; }
        [IgnoreDataMember]
        public virtual Agencia Agencia_Entrega { get; set; }
    }
}