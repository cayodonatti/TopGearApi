namespace TopGearApi.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Carroes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carroes()
        {
            Locacaos = new HashSet<Locacaos>();
            Items = new HashSet<Items>();
        }

        public int Id { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        [StringLength(7)]
        public string Placa { get; set; }

        public int Ano { get; set; }

        public int AgenciaId { get; set; }

        public int CategoriaId { get; set; }

        public string UrlImagem { get; set; }

        public virtual Agencias Agencias { get; set; }

        public virtual Categorias Categorias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locacaos> Locacaos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Items> Items { get; set; }
    }
}
