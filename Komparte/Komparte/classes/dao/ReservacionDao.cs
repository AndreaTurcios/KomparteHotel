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
    class ReservacionDao : ConnectionToSql
    {
        DataTable tabla = new DataTable();

        public DataTable all_reservacion()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_all_reservacion";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    //se cierra
                    command.CommandType = CommandType.Text;
                    return tabla;
                }
            }
        }

        public int create_reservacion(Reservacion res)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_create_reservacion";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @acompaniante varchar(30),
                        @num_noches int,
                        @checkin char(6),
                        @checkout char(6),
                        @pk_estado int,
                        @pk_servicio int,
                        @pk_cliente int

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("acompaniante ", res.acompaniante);
                    command.Parameters.AddWithValue("num_noches ", res.numero_noches);
                    command.Parameters.AddWithValue("checkin", res.checkin);
                    command.Parameters.AddWithValue("checkout", res.checkout);
                    command.Parameters.AddWithValue("pk_estado", res.pk_estado_reservacion);
                    command.Parameters.AddWithValue("pk_servicio", res.pk_servicio_reservacion);
                    command.Parameters.AddWithValue("pk_cliente", res.pk_cliente);
                    result = command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;
                }
                return result;
            }
        }


        public Reservacion get_reservacion_by_id(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_one_reservacion";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Reservacion obj = new Reservacion
                        {
                            id = (int)reader[0],
                            acompaniante = reader[1].ToString(),
                            numero_noches = (int)reader[2],
                            checkin = reader[3].ToString(),
                            checkout = reader[4].ToString(),
                            pk_estado_reservacion = (int) reader[5],
                            pk_servicio_reservacion = (int)reader[6],
                            pk_cliente = (int)reader[7]
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

        public int edit_reservacion(Reservacion res)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_update_reservacion";
                    command.CommandType = CommandType.StoredProcedure;
                    /**
                     * Datos de procedimiento almacenado
                        @acompaniante varchar(30),
                        @num_noches int,
                        @checkin char(6),
                        @checkout char(6),
                        @pk_estado int,
                        @pk_servicio int,
                        @pk_cliente int,
                        @id int

                     * command.Parameters.AddWithValue("", emp.);
                     */
                    command.Parameters.AddWithValue("acompaniante", res.acompaniante);
                    command.Parameters.AddWithValue("num_noches", res.numero_noches);
                    command.Parameters.AddWithValue("checkin", res.checkin);
                    command.Parameters.AddWithValue("checkout", res.checkout);
                    command.Parameters.AddWithValue("pk_estado", res.pk_estado_reservacion);
                    command.Parameters.AddWithValue("pk_servicio", res.pk_servicio_reservacion);
                    command.Parameters.AddWithValue("pk_cliente", res.pk_cliente);
                    command.Parameters.AddWithValue("id", res.id);
                    result = command.ExecuteNonQuery();
                }
                return result;
            }
        }

        public int simply_delete_reservacion(int id)
        {
            int result = -1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_delete_reservacion";
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
