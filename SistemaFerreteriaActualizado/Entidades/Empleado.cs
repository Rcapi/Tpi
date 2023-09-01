using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleado : Usuario
    {
        [Key]
        public int Legajo
        {
            get => default;
            set
            {
            }
        }
    }
}