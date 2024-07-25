using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Distrito
    {
        public string IdDistrito { get; set; }
        public string Descripcion { get; set; }
        public string IdProvincia { get; set; }
        public string IdDepartamento { get; set; }

        public Provincia oProvincia { get; set; }
        public Departamento oDepartamento { get; set; }
    }
}
