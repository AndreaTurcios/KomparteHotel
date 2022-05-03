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
    class ClienteDao : ConnectionToSql
    {
        DataTable tabla = new DataTable();

        public DataTable all_clientes() {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_all_clientes";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    //se cierra
                    command.CommandType = CommandType.Text;
                    return tabla;
                }
            }
        }

        public IEnumerable<Cliente> get_all_cliente()
        {
            var clienteList = new List<Cliente>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from cliente";
                    //command.CommandType = CommandType.StoredProcedure;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) //Agregar los resultados en la lista 
                        {
                            var obj = new Cliente
                            {
                                id = (int)reader[0],
                                nombre = reader[1].ToString(),
                                dui = reader[2].ToString(),
                                telefono= reader[3].ToString(),
                                direccion = reader[4].ToString(),
                                correo = reader[5].ToString(),
                                pk_estado_cliente = (int) reader[6],
                                pk_hotel_cliente = (int) reader[7]
                            };
                            clienteList.Add(obj);
                        }
                    }

                }
            }
            return clienteList;
        }

        public int create_cliente(Cliente cli)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_create_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @nombre varchar(30),
                        @dui varchar(30),
                        @telefono varchar(30),
                        @direccion varchar(30),
                        @correo varchar(50),
                        @pk_estado int,
                        @pk_hotel int

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("nombre", cli.nombre);
                    command.Parameters.AddWithValue("dui", cli.dui);
                    command.Parameters.AddWithValue("telefono", cli.telefono);
                    command.Parameters.AddWithValue("direccion", cli.direccion);
                    command.Parameters.AddWithValue("correo", cli.correo);
                    command.Parameters.AddWithValue("pk_estado", cli.pk_estado_cliente);
                    command.Parameters.AddWithValue("pk_hotel", cli.pk_hotel_cliente);
                    result = command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;
                }
                return result;
            }
        }

        public Cliente get_cliente_by_id(int id) 
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_one_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Cliente obj = new Cliente
                        {
                            id = (int)reader[0],
                            nombre = reader[1].ToString(),
                            dui = reader[2].ToString(),
                            telefono = reader[3].ToString(),
                            direccion = reader[4].ToString(),
                            correo = reader[5].ToString(),
                            pk_estado_cliente = (int) reader[6],
                            pk_hotel_cliente = (int) reader[7]
                        };
                        command.CommandType = CommandType.Text;
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

        public int edit_cliente(Cliente cli) 
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "pro_edit_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @nombre varchar(30),
                        @dui varchar(30),
                        @telefono varchar(30),
                        @direccion varchar(30),
                        @correo varchar(50),
                        @pk_estado int,
                        @pk_hotel int,
                        @id int

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("nombre",cli.nombre);
                    command.Parameters.AddWithValue("dui", cli.dui);
                    command.Parameters.AddWithValue("telefono", cli.telefono);
                    command.Parameters.AddWithValue("direccion", cli.direccion);
                    command.Parameters.AddWithValue("correo", cli.correo);
                    command.Parameters.AddWithValue("pk_estado", cli.pk_estado_cliente);
                    command.Parameters.AddWithValue("pk_hotel", cli.pk_hotel_cliente);
                    command.Parameters.AddWithValue("id", cli.id);
                    result = command.ExecuteNonQuery();
                }
                return result;
            }
        }

        public int simply_delete_cliente(int id) 
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_delete_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @estado varchar(30)

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("id", id);

                    result = command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;
                }
                return result;
            }
        }

    }
}
