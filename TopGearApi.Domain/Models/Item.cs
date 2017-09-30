using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TopGearApi.Domain.Models
{
    public class Item : IEntity
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Carro> Carros { get; set; }
    }
}
