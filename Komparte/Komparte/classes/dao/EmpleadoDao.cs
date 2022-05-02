using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komparte.Class;
using Komparte.classes.entidades;
using System.Data;
using System.Data.SqlClient;

namespace Komparte.classes.dao
{

    class EmpleadoDao : ConnectionToSql
    {
        DataTable tabla = new DataTable();
        public DataTable all_empleados()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_all_empleados";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    //se cierra
                    command.CommandType = CommandType.Text;
                }
                return tabla;
            }
        }

        public Empleado get_empleado_by_id(int id) 
        {
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_one_empleado";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Empleado emp = new Empleado
                        {
                            id_empleado = (int) reader[0],
                            nombre_empleado = reader[1].ToString(),
                            nombre_usuario = reader[2].ToString(),
                            contrasenia_usuario = reader[3].ToString(),
                            dui_empleado = reader[4].ToString(),
                            telefono = reader[5].ToString(),
                            direccion = reader[6].ToString(),
                            correo = reader[7].ToString(),
                            pk_estado_empleado = (int) reader[8],
                            pk_tipo_empleado = (int)reader[9],
                            pk_hotel_empleado = (int) reader[10]

                        };
                        command.CommandType = CommandType.Text;
                        return emp;
                    }
                    else 
                    {
                        //se cierra
                        command.CommandType = CommandType.Text;
                        return null;
                    }
                }
            }
        }


        public int create_empleado(Empleado emp)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_create_empleado";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @nombre varchar(30),
                        @usuario varchar(35),
                        @contrasenia varchar(35),
                        @dui varchar(30),
                        @telefono varchar(30),
                        @direccion varchar(30),
                        @correo varchar(50),
                        @pk_estado int,
                        @pk_rol int,
                        @pk_cargo int

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("nombre", emp.nombre_empleado);
                    command.Parameters.AddWithValue("usuario", emp.nombre_usuario);
                    command.Parameters.AddWithValue("contrasenia", emp.contrasenia_usuario);
                    command.Parameters.AddWithValue("dui", emp.dui_empleado);
                    command.Parameters.AddWithValue("telefono", emp.telefono);
                    command.Parameters.AddWithValue("direccion", emp.direccion);
                    command.Parameters.AddWithValue("correo", emp.correo);
                    command.Parameters.AddWithValue("pk_estado", emp.pk_estado_empleado);
                    command.Parameters.AddWithValue("pk_rol", emp.pk_tipo_empleado);
                    command.Parameters.AddWithValue("pk_cargo", emp.pk_hotel_empleado);
                    result = command.ExecuteNonQuery();
                }
                return result;
            }
        }

        public int edit_empleado(Empleado emp)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_edit_empleado";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @nombre varchar(30),
                        @usuario varchar(35),
                        @contrasenia varchar(35),
                        @dui varchar(30),
                        @telefono varchar(30),
                        @direccion varchar(30),
                        @correo varchar(50),
                        @pk_estado int,
                        @pk_rol int,
                        @pk_cargo int
                        @id int

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("nombre", emp.nombre_empleado);
                    command.Parameters.AddWithValue("usuario", emp.nombre_usuario);
                    command.Parameters.AddWithValue("contrasenia", emp.contrasenia_usuario);
                    command.Parameters.AddWithValue("dui", emp.dui_empleado);
                    command.Parameters.AddWithValue("telefono", emp.telefono);
                    command.Parameters.AddWithValue("direccion", emp.direccion);
                    command.Parameters.AddWithValue("correo", emp.correo);
                    command.Parameters.AddWithValue("pk_estado", emp.pk_estado_empleado);
                    command.Parameters.AddWithValue("pk_rol", emp.pk_tipo_empleado);
                    command.Parameters.AddWithValue("pk_cargo", emp.pk_hotel_empleado);
                    command.Parameters.AddWithValue("id", emp.id_empleado);
                    result = command.ExecuteNonQuery();
                }
                return result;
            }
        }

        
    }

    
}
