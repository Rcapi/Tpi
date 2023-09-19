namespace CDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HerramientaElectrica")]
    public partial class HerramientaElectrica
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Potencia { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Modelo { get; set; }

        [StringLength(30)]
        public string Codigo { get; set; }

        public virtual Herramienta Herramienta { get; set; }
    }
}
