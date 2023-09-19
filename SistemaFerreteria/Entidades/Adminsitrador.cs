using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Adminsitrador : Usuario
    {
        [Key]
        public int ID
        {
            get => default;
            set
            {
            }
        }
    }
}