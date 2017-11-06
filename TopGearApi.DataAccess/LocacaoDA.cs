using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.DataAccess
{
    public class LocacaoDA : TopGearDA<Locacao>
    {
        public static Locacao GetAtivaByCarro(int carroId)
        {
            using (var context = GetContext())
            {
                return context.Set<Locacao>().Where(l => l.CarroId == carroId && !l.Finalizada).FirstOrDefault();
            }
        }

        public static List<Locacao> GetByCliente (int ClienteId)
        {
            using (var context = GetContext())
            {
                return (
                        from loc in context.Set<Locacao>()
                        join cli in context.Set<Cliente>() on loc.ClienteId equals cli.Id
                        where cli.Id == ClienteId
                        select loc
                    )
                    .ToList();
            }
        }

        public static bool CancelarLocacao(int IdLocacao)
        {
            using (var context = GetContext())
            {
                var loc = context.Set<Locacao>().Where(l => l.Id == IdLocacao).FirstOrDefault();
                loc.Cancelada = true;

                context.SaveChanges();
            }

            return true;
        }
    }
}
