using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopGearApi.Domain.Models
{
    public class Mensagem : IEntity
    {
        public int Id { get; set; }

        public string Texto { get; set; }
        public int Origem { get; set; }
    }
}
