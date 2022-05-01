﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komparte.classes.dao;
using System.Data;
using Komparte.classes.entidades;

namespace Komparte.classes.model
{
    class EmpleadosModel
    {
        private EmpleadoDao empleadoDao = new EmpleadoDao();
        

        public DataTable f_all_empleados() {
            DataTable tabla = new DataTable();
            tabla = empleadoDao.all_empleados();
            /*https://docs.microsoft.com/es-es/dotnet/desktop/winforms/controls/remove-autogenerated-columns-from-a-wf-datagridview-control?view=netframeworkdesktop-4.8#:~:text=Para%20ello%2C%20llame%20al%20m%C3%A9todo,de%20las%20columnas%20sin%20mostrarlo.
            */
            tabla.Columns.Remove("DUI");
            tabla.Columns.Remove("Telefono");
            tabla.Columns.Remove("Direccion");
            return tabla;
        }

        public int f_create_empleado(Empleado emp) {
            int result;
            result = empleadoDao.create_empleado(emp);
            return result;
        }

        public int f_editar_empleado(Empleado emp) {
            int result;
            result = empleadoDao.edit_empleado(emp);
            return result;
        }

        public Empleado fEmpleadoById(string str) {
            int id = Int32.Parse(str);
            Empleado emp = empleadoDao.get_empleado_by_id(id);
            return emp;
        }
    }
}