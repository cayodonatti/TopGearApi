using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopGearApi.Promotions
{
    public class Promotion
    {
        public DateTime Validade { get; set; }
        public double Valor { get; set; }
        public int QtdDias { get; set; }
        public int CategoriaId { get; set; }
    }
}
