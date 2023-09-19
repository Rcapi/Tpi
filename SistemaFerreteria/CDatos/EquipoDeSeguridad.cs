namespace CDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquipoDeSeguridad")]
    public partial class EquipoDeSeguridad
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Talle { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Codigo { get; set; }

        public double? Peso { get; set; }

        [StringLength(50)]
        public string TipoEquipo { get; set; }

        [StringLength(50)]
        public string Normativa { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
