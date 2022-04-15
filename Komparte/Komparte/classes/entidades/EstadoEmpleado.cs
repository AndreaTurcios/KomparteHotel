using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes.entidades
{
    public class EstadoEmpleado
    {
        public int idEstadoEmpleado { get; set; }
        public string estado { get; set; }

        public EstadoEmpleado()
        {

        }

        public EstadoEmpleado(int idEstadoEmpleado, string estado)
        {
            this.idEstadoEmpleado = idEstadoEmpleado;
            this.estado = estado;
        }

        public override string ToString()
        {
            return estado;
        }

        
    }
}
