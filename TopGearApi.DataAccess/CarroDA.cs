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
        public static IEnumerable<Carro> GetByItem(int itemId)
        {
            using (var context = GetContext())
            {
                return (
                        from c in context.Set<Carro>()
                        where c.Itens.FirstOrDefault(i => i.Id == itemId) != null
                        select c
                    )
                    .ToList(); 
            }
        }

        public static IEnumerable<Carro> GetByCategoria(int categoriaId)
        {
            using (var context = GetContext())
            {
                return (
                        from c in context.Set<Carro>()
                        where c.CategoriaId == categoriaId
                        select c
                    )
                    .ToList();
            }
        }

        public static IEnumerable<Carro> GetDisponiveis(DateTime inicial, DateTime final, int? itemId)
        {
            using (var context = GetContext())
            {
                return (
                        from c in context.Set<Carro>()
                        join l in context.Set<Locacao>() on c equals l.Carro into cl
                        from x in cl.DefaultIfEmpty()
                        where (
                                    x == null || x.Finalizada || x.Cancelada || (x.Entrega < inicial && x.Retirada > final)
                              )
                              &&
                              (
                                  itemId == null || c.Itens.FirstOrDefault(i => i.Id == itemId) != null
                              )
                        select c
                        )
                        .ToList();
            }
        }
    }
}
