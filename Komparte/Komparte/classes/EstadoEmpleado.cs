using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes
{
    class EstadoEmpleado
    {
        private int id;
        private string estadoempleado;

        public EstadoEmpleado()
        {

        }

        public EstadoEmpleado(int id, string estadoempleado)
        {
            this.id = id;
            this.estadoempleado = estadoempleado;
        }

        public override string ToString() {
            return estadoempleado;
        }
    }
}
