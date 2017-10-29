using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.Data
{
    public class TopGearContext : DbContext
    {
        public TopGearContext() : base(ConfigurationManager.ConnectionStrings["TopGear"].ConnectionString)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Carro> Carro { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Agencia> Agencia { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Mensagem> Mensagem { get; set; }
    }
}
