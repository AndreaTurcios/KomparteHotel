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
    class EmpleadoFilter
    {
        public int id_empleado { get; set; }

        [Required(ErrorMessage = "Por favor ingrese nombre")]
        // [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe contener un mínimo de 3 caracteres.")]
        public string nombre_empleado { get; set; }

        [DisplayName("Usuario")]//Nombre a visualizar.
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public string nombre_usuario { get; set; }

        //Posición 2
        [DisplayName("Contraseña")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización (Por ejemplo no mostrar en el datagridview).
        [Required(ErrorMessage = "Por favor ingrese una contraseña.")]//Valicaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La contraseña debe contener un mínimo de 5 caracteres.")]
        public string contrasenia_usuario { get; set; }
        
        [Required(ErrorMessage = "Por favor ingrese DUI.")]//Validaciones
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El apellido debe contener 10 digitos incluyendo guion")]
        public string dui_empleado { get; set; }

        //[DisplayName("Telefono")]//Nombre a visualizar.
        //[Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese DUI.")]//Validaciones
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El telefono debe contener 8 digitos incluyendo guion")]
        public string telefono { get; set; }

        //[DisplayName("Direccion")]//Nombre a visualizar.
        //[Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese Direccion.")]//Validaciones
        public string direccion { get; set; }

        [DisplayName("Email")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese correo electrónico.")]//Validaciones
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido: example@gmail.com")]
        public string correo { get; set; }

        [DisplayName("Estado")]//Nombre a visualizar.
        // [Required(ErrorMessage = "Por favor ingrese Estado.")]//Validaciones
        // [EmailAddress(ErrorMessage = "Ingrese un estado válido: example@gmail.com")]
        public int pk_estado_empleado { get; set; }

        [DisplayName("TipoEmpleado")]//Nombre a visualizar.
        //[Required(ErrorMessage = "Por favor ingrese correo electrónico.")]//Validaciones
        // [EmailAddress(ErrorMessage = "Ingrese un estado válido: example@gmail.com")]
        public int pk_tipo_empleado { get; set; }


        [DisplayName("IdHotel")]//Nombre a visualizar.
        //[Required(ErrorMessage = "Por favor ingrese Hotel.")]//Validaciones
        // [EmailAddress(ErrorMessage = "Ingrese un estado válido: example@gmail.com")]
        public int pk_hotel_empleado { get; set; }


        public Empleado empleado() {
            Empleado emp = new Empleado();
            emp.id_empleado = this.id_empleado;
            emp.nombre_empleado = this.nombre_empleado;
            emp.nombre_usuario = this.nombre_usuario;
            emp.contrasenia_usuario = this.contrasenia_usuario;
            emp.dui_empleado = this.dui_empleado;
            emp.telefono = this.telefono;
            emp.direccion = this.direccion;
            emp.correo = this.correo;
            emp.pk_estado_empleado = this.pk_estado_empleado;
            emp.pk_tipo_empleado = this.pk_tipo_empleado;
            emp.pk_hotel_empleado = this.pk_hotel_empleado;
            return emp;
        }

        public Empleado empleado(string id)
        {
            Empleado emp = new Empleado();
            emp.id_empleado = Int32.Parse(id);
            emp.nombre_empleado = this.nombre_empleado;
            emp.nombre_usuario = this.nombre_usuario;
            emp.contrasenia_usuario = this.contrasenia_usuario;
            emp.dui_empleado = this.dui_empleado;
            emp.telefono = this.telefono;
            emp.direccion = this.direccion;
            emp.correo = this.correo;
            emp.pk_estado_empleado = this.pk_estado_empleado;
            emp.pk_tipo_empleado = this.pk_tipo_empleado;
            emp.pk_hotel_empleado = this.pk_hotel_empleado;
            return emp;
        }

    }
}
