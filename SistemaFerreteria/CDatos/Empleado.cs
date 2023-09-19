namespace CDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [Key]
        public int Legajo { get; set; }

        [Required]
        [StringLength(10)]
        public string Dni { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
