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
                IEnumerable<Carro> carros = (from c in context.Set<Carro>() select c);

                List<Carro> carrosDisponiveis = new List<Carro>();

                //foreach(Carro c in carros)
                //{
                //    var l = LocacaoDA.GetAtivaByCarro(c.Id, inicial, final);

                //    if (l is null) carrosDisponiveis.Add(c);
                //}

                return carrosDisponiveis;
            }
        }
    }
}
