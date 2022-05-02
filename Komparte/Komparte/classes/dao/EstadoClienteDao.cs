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
    class EstadoClienteDao : ConnectionToSql
    {
        DataTable tabla = new DataTable();

        public DataTable all_estado_empleado() 
        {

            using (var connection = GetConnection()) 
            {
                connection.Open();
                using (var command = new SqlCommand()) 
                {
                    command.Connection = connection;
                    command.CommandText = "select * from estado_cliente";
                    //command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    //se cierra
                    command.CommandType = CommandType.Text;
                    return tabla;
                }
            }
        }

        public IEnumerable<EstadoCliente> get_all_estado_cliente()
        {
            var estadoClienteList = new List<EstadoCliente>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from estado_cliente";
                    //command.CommandType = CommandType.StoredProcedure;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) //Agregar los resultados en la lista 
                        {
                            var estadoEmpleadoObj = new EstadoCliente
                            {
                                id= (int)reader[0],
                                estado = reader[1].ToString()
                            };
                            estadoClienteList.Add(estadoEmpleadoObj);
                        }
                    }

                }
            }
            return estadoClienteList;
        }

        public EstadoCliente get_cliente_by_id(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from estado_cliente where ID_estado_cliente = @id";
                    //command.CommandType = CommandType.StoredProcedure;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        EstadoCliente obj = new EstadoCliente()
                        {
                            id = (int)reader[0],
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

        public int create_estado(EstadoCliente est)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_create_estado_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @estado varchar(30)

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("estado", est.estado);
                    result = command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;
                }
                return result;
            }
        }

        public int edit_estado(EstadoCliente est)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_edit_estado_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @estado varchar(30)

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("estado", est.estado);
                    command.Parameters.AddWithValue("id", est.id);
                    
                    result = command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;
                }
                return result;
            }
        }

        public int delete_estado(EstadoCliente est)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_delete_estado_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @estado varchar(30)

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("id", est.id);

                    result = command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;
                }
                return result;
            }
        }




    }
}
