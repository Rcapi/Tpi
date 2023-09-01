using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente : Usuario
    {
        [Key]
        public int NroCli
        {
            get => default;
            set
            {
            }
        }
    }
}