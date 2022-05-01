using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes.entidades
{
    class Empleado
    {
        public int id_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasenia_usuario { get; set; }
        public string dui_empleado { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public int pk_estado_empleado {get; set;}
        public int pk_tipo_empleado { get; set; }
        public int pk_hotel_empleado { get; set; }
    }
}
