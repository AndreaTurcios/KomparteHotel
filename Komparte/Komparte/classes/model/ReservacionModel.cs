using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Komparte.classes.entidades;
using Komparte.classes.dao;

namespace Komparte.classes.model
{
    class ReservacionModel
    {
        private ReservacionDao reservacionDao = new ReservacionDao();

        public DataTable f_all_reservacion()
        {
            DataTable tabla = new DataTable();
            tabla = reservacionDao.all_reservacion();
            return tabla;
        }
        public int f_create_reservacion(Reservacion obj)
        {
            int result;
            result = reservacionDao.create_reservacion(obj);
            return result;
        }

        public Reservacion fReservacionById(string srt)
        {
            Reservacion cli = reservacionDao.get_reservacion_by_id(Int32.Parse(srt));
            return cli;
        }

        public int f_update_reservacion(Reservacion obj)
        {
            int result;
            result = reservacionDao.edit_reservacion(obj);
            return result;
        }

        public int f_delete_reservacion(string srt)
        {
            int result;
            result = reservacionDao.simply_delete_reservacion(Int32.Parse(srt));
            return result;
        }
    }
}
