using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes.entidades
{
    class EstadoCliente
    {
        public int id {get; set;}
        public string estado { get; set; }

        public override string ToString()
        {
            return estado;
        }
    }
}
