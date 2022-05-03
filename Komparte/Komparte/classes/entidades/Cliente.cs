using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes.entidades
{
    class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string dui { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public int pk_estado_cliente { get; set; }
        public int pk_hotel_cliente { get; set; }


        public override string ToString()
        {
            return nombre;
        }
    }
}
