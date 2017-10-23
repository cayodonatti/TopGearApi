using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TopGearApi.Domain.Models
{
    public class Cliente : IEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(11)]
        public string CPF { get; set; }
        public string Cartao { get; set; }
        [Required]
        public string Senha { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Locacao> Locacoes { get; set; }
    }
}