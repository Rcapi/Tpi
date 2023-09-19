namespace CDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administrador")]
    public partial class Administrador
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Dni { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
