using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komparte.classes.dao;
using System.Data;
using Komparte.classes.entidades;
using Komparte.classes.filter;

namespace Komparte.classes.model
{
    class EstadoClienteModel
    {
        private EstadoClienteDao estadoClienteDao = new EstadoClienteDao();
        

        public DataTable f_all_estados() {
            DataTable tabla = new DataTable();
            tabla = estadoClienteDao.all_estado_empleado();
            return tabla;
        }

        public int f_create_estado(EstadoCliente est) {
            int result;
            result = estadoClienteDao.create_estado(est);
            return result;
        }

        public int f_update_estado(EstadoCliente est) {
            int result;
            result = estadoClienteDao.edit_estado(est);
            return result;
        }

        public int f_delete_estado(EstadoCliente est)
        {
            int result;
            result = estadoClienteDao.delete_estado(est);
            return result;
        }

        //Filter 
        public EstadoClienteFilter filterFrm() {
            EstadoClienteFilter filter = new EstadoClienteFilter();

            return filter;
        }

    }
}
