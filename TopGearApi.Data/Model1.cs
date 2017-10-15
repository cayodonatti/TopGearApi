namespace TopGearApi.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Agencias> Agencias { get; set; }
        public virtual DbSet<Carroes> Carroes { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Locacaos> Locacaos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencias>()
                .HasMany(e => e.Carroes)
                .WithRequired(e => e.Agencias)
                .HasForeignKey(e => e.AgenciaId);

            modelBuilder.Entity<Agencias>()
                .HasMany(e => e.Locacaos)
                .WithOptional(e => e.Agencias)
                .HasForeignKey(e => e.Agencia_EntregaId);

            modelBuilder.Entity<Agencias>()
                .HasMany(e => e.Locacaos1)
                .WithOptional(e => e.Agencias1)
                .HasForeignKey(e => e.Agencia_RetiradaId);

            modelBuilder.Entity<Carroes>()
                .HasMany(e => e.Locacaos)
                .WithRequired(e => e.Carroes)
                .HasForeignKey(e => e.CarroId);

            modelBuilder.Entity<Carroes>()
                .HasMany(e => e.Items)
                .WithMany(e => e.Carroes)
                .Map(m => m.ToTable("ItemCarroes").MapLeftKey("Carro_Id").MapRightKey("Item_Id"));

            modelBuilder.Entity<Categorias>()
                .HasMany(e => e.Carroes)
                .WithRequired(e => e.Categorias)
                .HasForeignKey(e => e.CategoriaId);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Locacaos)
                .WithRequired(e => e.Clientes)
                .HasForeignKey(e => e.ClienteId);
        }
    }
}
