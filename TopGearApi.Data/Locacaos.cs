namespace TopGearApi.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Locacaos
    {
        public int Id { get; set; }

        public DateTime Retirada { get; set; }

        public DateTime Entrega { get; set; }

        public int? Agencia_EntregaId { get; set; }

        public int? Agencia_RetiradaId { get; set; }

        public int CarroId { get; set; }

        public int ClienteId { get; set; }

        public bool Finalizada { get; set; }

        public DateTime? Entrega_Real { get; set; }

        public virtual Agencias Agencias { get; set; }

        public virtual Agencias Agencias1 { get; set; }

        public virtual Carroes Carroes { get; set; }

        public virtual Clientes Clientes { get; set; }
    }
}
