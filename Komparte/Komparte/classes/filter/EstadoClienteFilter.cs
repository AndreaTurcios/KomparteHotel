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
    class EstadoClienteFilter
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Por favor defina el estado")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El estado debe contener un mínimo de 3 y maximo 30 caracteres .")]
        public string estado { get; set; }

        public EstadoCliente estadoCliente()
        {
            EstadoCliente est = new EstadoCliente();
            est.id = this.id;
            est.estado = this.estado;
            return est;
        }

        public EstadoCliente estadoCliente(string id)
        {
            EstadoCliente est = new EstadoCliente();
            est.id = Int32.Parse(id);
            est.estado = this.estado;
            return est;
        }
    }

    
}
