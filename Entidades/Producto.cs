﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Producto
    {
        public Cliente Cliente
        {
            get => default;
            set
            {
            }
        }
        [Key]
        public string Codigo
        {
            get => default;
            set
            {
            }
        }

        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public string Descripcion
        {
            get => default;
            set
            {
            }
        }

        public float Precio
        {
            get => default;
            set
            {
            }
        }

        public int Stock
        {
            get => default;
            set
            {
            }
        }
    }
}