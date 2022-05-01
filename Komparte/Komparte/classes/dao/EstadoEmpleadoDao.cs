using Common;
using DataAccess.DBServices.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komparte.Class;
using Komparte.classes.entidades;

namespace Komparte.classes.dao
{
    class EstadoEmpleadoDao : ConnectionToSql
    {
        /// Esta clase hereda de clase ConnectionToSql.
        /// Aquí se realiza las diferentes transacciones y consultas a la base de datos de la entidad
        /// usuario.
        /// 

        public IEnumerable<EstadoEmpleado> GetAllEstadoEmpleados() {
            var estadoEmpleadosList = new List<EstadoEmpleado>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "select * from estado_empleado";
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) //Agregar los resultados en la lista 
                        {
                            var estadoEmpleadoObj = new EstadoEmpleado
                            {
                                idEstadoEmpleado = (int)reader[0],
                                estado = reader[1].ToString()
                            };
                            estadoEmpleadosList.Add(estadoEmpleadoObj);
                        }
                    }
                }
            }
                return estadoEmpleadosList;
        }

        public EstadoEmpleado get_estado_empleado_by_id(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from estado_empleado where ID_estado_empleado = @id";
                    //command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        EstadoEmpleado obj = new EstadoEmpleado()
                        {
                            idEstadoEmpleado = (int)reader[0],
                            estado = reader[1].ToString()

                        };
                        //command.CommandType = CommandType.Text;
                        return obj;
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

    }
}
