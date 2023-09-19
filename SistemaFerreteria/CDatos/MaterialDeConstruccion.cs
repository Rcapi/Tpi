namespace CDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialDeConstruccion")]
    public partial class MaterialDeConstruccion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Marca { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Codigo { get; set; }

        [StringLength(15)]
        public string Medidas { get; set; }

        [StringLength(30)]
        public string TipoMaterial { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
