namespace CDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HerramientaManual")]
    public partial class HerramientaManual
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Modelo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string Codigo { get; set; }

        public virtual Herramienta Herramienta { get; set; }
    }
}
