using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes.entidades
{
    class Reservacion
    {
        public int id {get; set;}
        public string acompaniante { get; set; }
        public int numero_noches { get; set; }
        public string checkin { get; set; }
        public string checkout { get; set; }

        public int pk_estado_reservacion { get; set;  }
        public int pk_servicio_reservacion { get; set; }
        public int pk_cliente { get; set; }

    }
}
