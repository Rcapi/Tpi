namespace CDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Herramienta")]
    public partial class Herramienta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Herramienta()
        {
            HerramientaElectricas = new HashSet<HerramientaElectrica>();
            HerramientaManuals = new HashSet<HerramientaManual>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Modelo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Codigo { get; set; }

        public virtual Producto Producto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HerramientaElectrica> HerramientaElectricas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HerramientaManual> HerramientaManuals { get; set; }
    }
}
