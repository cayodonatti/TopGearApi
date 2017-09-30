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
                return (
                        from c in context.Set<Carro>()
                        where c.Itens.Where(i => i.Id == ItemId).FirstOrDefault() != null
                        select c
                    )
                    .ToList(); 
            }
        }

        public static IEnumerable<Carro> GetDisponiveis()
        {
            using (var context = GetContext())
            {
                return (
                        from c in context.Set<Carro>()
                        join l in context.Set<Locacao>() on c equals l.Carro into cl
                        from x in cl.DefaultIfEmpty()
                        where x == null || x.Finalizada == false 
                        select c
                        )
                        .ToList();
            }
        }

        public static IEnumerable<Carro> GetDisponiveisByAgencia(int AgenciaId)
        {
            using (var context = GetContext())
            {
                return (
                        from c in context.Set<Carro>()
                        join l in context.Set<Locacao>() on c equals l.Carro into cl
                        from x in cl.DefaultIfEmpty()
                        where (x == null || x.Finalizada == false) && c.AgenciaId == AgenciaId
                        select c
                        )
                        .ToList();
            }
        }
    }
}
