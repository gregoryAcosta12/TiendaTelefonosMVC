﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        public string IdProvincia { get; set; }
        public string Descripcion { get; set; }
        public string IdDepartamento { get; set; }

        public Departamento oDepartamento { get; set; }


    }
}
