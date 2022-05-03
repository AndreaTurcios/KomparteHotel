using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes.entidades
{
    class Servicio
    {
        public int id { get; set; }
        public string servicio { get; set; }

        public override string ToString()
        {
            return servicio;
        }
    }
}
