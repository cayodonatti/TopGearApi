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
    public static class TopGearDA<T> where T : class, IEntity
    {
        public static IEnumerable<T> Get()
        {
            using (var context = new TopGearContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public static T Get(int id)
        {
            using (var context = new TopGearContext())
            {
                return context.Set<T>().Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public static void Insert(T entity)
        {
            using (var context = new TopGearContext())
            {
                context.Set<T>().Add(entity);
            }
        }

        public static void Delete(int id)
        {
            using (var context = new TopGearContext())
            {
                var entity = Get(id);
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public static void Update(T entity)
        {
            using (var context = new TopGearContext())
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
            using (var context = new TopGearContext())
            {
                return context.Set<Usuario>().Where(u => u.Token == token).ToArray().Length > 0;
            }
        }
    }
}
