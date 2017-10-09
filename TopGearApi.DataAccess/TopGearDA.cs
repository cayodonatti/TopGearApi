using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Data;
using TopGearApi.Domain.Models;

namespace TopGearApi.DataAccess
{
    public class TopGearDA<T> where T : class, IEntity
    {
        protected static DbContext GetContext()
        {
            return new TopGearContext();
        }

        public static IEnumerable<T> Get()
        {
            using (var context = GetContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public static T Get(int id)
        {
            using (var context = GetContext())
            {
                return context.Set<T>().Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public static int Insert(T entity)
        {
            using (var context = GetContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();

                return entity.Id;
            }
        }

        public static void Delete(int id)
        {
            using (var context = GetContext())
            {
                var entity = Get(id);
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public static void Update(T entity)
        {
            using (var context = GetContext())
            {
                var atual = context.Set<T>().Find(entity.Id);

                if (atual != null)
                {
                    context.Entry(atual).CurrentValues.SetValues(entity);
                }

                context.SaveChanges();
            }
        }

        public static bool CheckToken(string token)
        {
            using (var context = GetContext())
            {
                return context.Set<Usuario>().Where(u => u.Token == token).ToArray().Length > 0;
            }
        }
    }
}
