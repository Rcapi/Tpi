//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaFerreteria.CDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int Legajo { get; set; }
        public string Dni { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
