using Common;
using DataAccess.DBServices.Entities;
using Komparte.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes
{
    public class ActivityDao : ConnectionToSql
    {/*
        public int CreateActivity(ActivityDao activity)
        {//Insertar nuevo usuario.
            int result = -1;
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"insert into actividad 
	                                        values (@actividad)";

                    command.Parameters.AddWithValue("@actividad", activity.ac);
                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery(); //Ejecutar el comando de texto y asignar el resultado al campo result.
                }
            }
            return result;//retornar el numero de filas afectadas de la transaccion. 
    }
        public int ModifyActivity(Activity activity)
        {//Actualizar usuario.
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"update  actividad	
	                                        set actividades=@actividad where id=@id ";
                    command.Parameters.AddWithValue("@userName", activity.Actividad);
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
        public int RemoveActivity(int id)
        {//Eliminar usuario.
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"delete from actividad where ID_actividad=@id ";
                    command.Parameters.AddWithValue("@id", id);

                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
        public User GetActivityById(int id)
        {//Obtener usuario por id.
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from actividad where ID_actividad=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var activityObj = new Activity
                        {
                            Id = (int)reader[0],
                            Actividad = reader[1].ToString()
                        };
                        return activityObj; //Retornar resultado (objeto).
                    }
                    else
                        return null;//Retornar NULL si no hay resultado.
                }
            }
        }
       
        public IEnumerable<Activity> GetAllActivity()
        {//Listar 
            var activityList = new List<Activity>();//Crear lista generica de usuarios.

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from actividad ";
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Agregar los resultados en la lista mientras el lector siga leyendo las filas.
                        {
                            var activityObj = new Activity
                            {
                                Id = (int)reader[0],
                                Actividad = reader[1].ToString()
                            };
                            activityList.Add(activityObj);
                        }
                    }
                }
            }
            return activityList; //Retornar lista.
        }
        */
    }
}

