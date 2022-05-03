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
    class ServicioModel
    {
        private ServicioDao servicioDao = new ServicioDao();
        public IEnumerable<Servicio> get_all_servicios()
        {
            return servicioDao.get_all_servicio();
        }

    }
}
