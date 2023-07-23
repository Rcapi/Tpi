using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ElementoDeSujecion : Producto
    {
        [Key]
        public string TipoElemento
        {
            get => default;
            set
            {
            }
        }

        public float Longitud
        {
            get => default;
            set
            {
            }
        }

        public float Capacidad
        {
            get => default;
            set
            {
            }
        }
    }
}