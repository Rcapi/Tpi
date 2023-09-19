namespace CDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElementoDeSujecion")]
    public partial class ElementoDeSujecion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string TipoElemento { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Codigo { get; set; }

        public double? Longitud { get; set; }

        public double? Capacidad { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
