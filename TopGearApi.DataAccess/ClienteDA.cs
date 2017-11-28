using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.DataAccess
{
    public class ClienteDA : TopGearDA<Cliente>
    {
        public static Cliente Login(string CPF, string Senha)
        {
            using (var context = GetContext())
            {
                return context.Set<Cliente>().FirstOrDefault(c => c.CPF == CPF && c.Senha == Senha);
            }
        }

        public static Cliente ObterPorEmail(string Email)
        {
            using (var context = GetContext())
            {
                return context.Set<Cliente>().FirstOrDefault(c => c.Email == Email);
            }
        }
    }
}
