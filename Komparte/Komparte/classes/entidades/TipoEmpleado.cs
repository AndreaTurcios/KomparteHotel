using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes.entidades
{
    class TipoEmpleado
    {
        public int idTipoEmpleado { get; set; }
        public string tipoEmpleado { get; set; }

        public override string ToString()
        {
            return tipoEmpleado;
        }
    }
}
