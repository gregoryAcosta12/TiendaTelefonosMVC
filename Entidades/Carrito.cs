﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        public Cliente oCliente { get; set; }
        public Producto oProducto { get; set; }




    }
}
