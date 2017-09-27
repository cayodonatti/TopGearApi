using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.DataAccess
{
    public class CarroDA : TopGearDA<Carro>
    {
        public static IEnumerable<Carro> GetByItem(int ItemId)
        {
            using (var context = GetContext())
            {
                return context.Set<Carro>().Where(c => c.Itens.Where(i => i.Id == ItemId).FirstOrDefault() != null).ToList();
            }
        }

        public static IEnumerable<Carro> GetDisponiveis()
        {
            using (var context = GetContext())
            {
                return context.Set<Carro>()
                    .Join(context.Set<Locacao>(), 
                               c => c, 
                               l => l.Carro, 
                               (c, l) => new { c, l }).DefaultIfEmpty()
                    .Where(x => x.l == null || x.l.Finalizada)
                    .Select(x => x.c).ToList();
            }
        }

        public static IEnumerable<Carro> GetDisponiveisByAgencia(int AgenciaId)
        {
            using (var context = GetContext())
            {
                return context.Set<Carro>()
                    .Join(context.Set<Locacao>(),
                               c => c,
                               l => l.Carro,
                               (c, l) => new { c, l }).DefaultIfEmpty()
                    .Where(x => x.l == null || x.l.Finalizada)
                    .Select(x => x.c)
                    .Where(c => c.AgenciaId == AgenciaId).ToList();
            }
        }
    }
}
