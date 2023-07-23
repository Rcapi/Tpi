using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class MaterialesDeConstruccion : Producto
    {
        [Key]
        public string Marca
        {
            get => default;
            set
            {
            }
        }

        public string Medida
        {
            get => default;
            set
            {
            }
        }

        public string TipoMaterial
        {
            get => default;
            set
            {
            }
        }
    }
}