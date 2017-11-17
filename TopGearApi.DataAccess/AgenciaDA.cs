using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.DataAccess
{
    public class AgenciaDA : TopGearDA<Agencia>
    {
        public static Agencia GetBySigla(string sigla)
        {
            using (var context = GetContext())
            {
                return (
                        context.Set<Agencia>().FirstOrDefault(a => a.Nome == sigla)
                    );
            }
        }
    }
}
