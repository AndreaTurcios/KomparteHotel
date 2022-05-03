using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Komparte.classes.entidades;

namespace Komparte.classes.filter
{
    class ReservacionFilter
    {
        public int id { get; set; }
        public string acompaniante { get; set; }
        public int numero_noches { get; set; }
        public string checkin { get; set; }
        public string checkout { get; set; }

        public int pk_estado_reservacion { get; set; }
        public int pk_servicio_reservacion { get; set; }
        public int pk_cliente { get; set; }

        public Reservacion reservacion() {
            Reservacion res = new Reservacion();
            res.id = this.id;
            res.acompaniante = this.acompaniante;
            res.numero_noches = this.numero_noches;
            res.checkin = this.checkin;
            res.checkout = this.checkout;
            res.pk_estado_reservacion = this.pk_estado_reservacion;
            res.pk_servicio_reservacion = this.pk_servicio_reservacion;
            res.pk_cliente = this.pk_cliente;
            return res;
        }

        public Reservacion reservacion(string id)
        {
            Reservacion res = new Reservacion();
            res.id = Int32.Parse(id);
            res.acompaniante = this.acompaniante;
            res.numero_noches = this.numero_noches;
            res.checkin = this.checkin;
            res.checkout = this.checkout;
            res.pk_estado_reservacion = this.pk_estado_reservacion;
            res.pk_servicio_reservacion = this.pk_servicio_reservacion;
            res.pk_cliente = this.pk_cliente;
            return res;
        }
    }
}
