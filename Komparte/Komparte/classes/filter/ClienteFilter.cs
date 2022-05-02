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
    class ClienteFilter
    {
        public int id { get; set; }
        
        [Required(ErrorMessage = "Por favor ingrese nombre")]
        // [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe contener un mínimo de 3 caracteres.")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese DUI.")]//Validaciones
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El DUI debe contener 10 digitos incluyendo guion")]
        public string dui { get; set; }

        [Required(ErrorMessage = "Por favor ingrese DUI.")]//Validaciones
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El telefono debe contener 8 digitos incluyendo guion")]
        public string telefono { get; set; }

        //[DisplayName("Direccion")]//Nombre a visualizar.
        //[Browsable(false)]//Ocultar visualización
       // [Required(ErrorMessage = "Por favor ingrese Direccion.")]//Validaciones
        public string direccion { get; set; }

        [DisplayName("Email")]//Nombre a visualizar.
        //[Required(ErrorMessage = "Por favor ingrese correo electrónico.")]//Validaciones
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido: example@gmail.com")]
        public string correo { get; set; }

        [DisplayName("TipoEmpleado")]//Nombre a visualizar.
        //[Required(ErrorMessage = "Por favor ingrese correo electrónico.")]//Validaciones
        // [EmailAddress(ErrorMessage = "Ingrese un estado válido: example@gmail.com")]
        public int pk_estado_cliente { get; set; }
        
        public int pk_hotel_cliente { get; set; }

        public Cliente cliente() {
            Cliente cli = new Cliente();

            cli.id = this.id;
            cli.nombre = this.nombre;
            cli.dui = this.dui;
            cli.telefono = this.telefono;
            cli.direccion = this.direccion;
            cli.correo = this.correo;
            cli.pk_estado_cliente = this.pk_estado_cliente;
            cli.pk_hotel_cliente = this.pk_hotel_cliente;

            return cli;
        }

        public Cliente cliente(string id)
        {
            Cliente cli = new Cliente();

            cli.id = Int32.Parse(id); 
            cli.nombre = this.nombre;
            cli.dui = this.dui;
            cli.telefono = this.telefono;
            cli.direccion = this.direccion;
            cli.correo = this.correo;
            cli.pk_estado_cliente = this.pk_estado_cliente;
            cli.pk_hotel_cliente = this.pk_hotel_cliente;

            return cli;
        }
    }
}
