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

namespace DataAccess.DBServices
{
    public class UserDao : ConnectionToSql
    {
        /// <summary>
        /// Esta clase hereda de clase ConnectionToSql.
        /// Aquí se realiza las diferentes transacciones y consultas a la base de datos de la entidad
        /// usuario.
        /// </summary>
        /// 

        public User Login(string username, string password)
        {//Validar el usuario y contraseña del usuario para el inicio de sesion.

            using (var connection = GetConnection()) //Obtener la conexion.
            {
                connection.Open(); //Abrir la conexion.
                using (var command = new SqlCommand())//Crear objeto SqlCommand.
                {
                    command.Connection = connection;//Establecer la conexión.
                    //Establecer el comando de texto.
                    command.CommandText = "select *from empleado where (nombre_usuario=@username and contrasenia_usuario=@pass) or (correo=@username and contrasenia_usuario=@pass)";
                    //Establecer los parametros.
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", password);
                    command.CommandType = CommandType.Text;//Establecer el tipo de comando.

                    SqlDataReader reader = command.ExecuteReader();//Ejecutar y establecer el lector.
                    if (reader.Read())//Si el lector tiene filas que leer.
                    {
                        var userObj = new User //Crear objeto y asignar los datos del resultado.
                        {
                            Id = (int)reader[0],
                            Username = reader[2].ToString(),
                            Password = reader[3].ToString(),
                            FirstName = reader[1].ToString(),
                            DUI = reader[4].ToString(),
                            Phone = reader[5].ToString(),
                            Direction = reader[6].ToString(),
                            Position = reader[8].ToString(),
                            Email = reader[7].ToString()
                        };
                        //Asignar los datos del usuario conectado actualmente en la aplicacion.
                        ActiveUser.Id = userObj.Id;                      
                        ActiveUser.Position = userObj.Position;
                        ActiveUser.Username = username;

                        return userObj; //Retornar el objeto usuario (Resultado)
                    }
                    else //Si la consulta no fue exitosa, retornar nulo.
                        return null;
                }
            }
        }
        public bool ValidateActiveUser()
        {//Seguridad de la aplicacion, utiliza este metodo para verificar que el usuario conectado sea valido.
            bool validUser = false;//Obtiene o establece si el usuario conectado es valido (Valor por defecto =falso).
            string activeUserPass = "";//Obtiene o establece la contraseña del usuario conectado.
            if (string.IsNullOrWhiteSpace(ActiveUser.Username) == false) //Ejecutar este fragmento de codigo siempre en cuando que el nombre usuario NO sea nulo o espacios en blanco.
            {
                using (var connection = GetConnection())//Obtener conexion
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //Obtener la contraseña del usuario conectado.
                        command.CommandText = "select contrasenia_usuario from empleado where ID_empleado=@id";//Establecer el comando de texto
                        command.Parameters.AddWithValue("@id", ActiveUser.Id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())//Si el lector tiene filas que leer, almacenar el resultado (Contraseña) en el campo activeUserPass.
                                activeUserPass = reader[0].ToString();
                            command.Parameters.Clear();//Limpiar los parametros para la siguiente consulta.
                        }
                        //Validar usuario conectado.
                        command.CommandText = "select *from empleado where nombre_usuario=@username or correo=@username and contrasenia_usuario=@pass and ID_empleado=@id";
                        command.Parameters.AddWithValue("@username", ActiveUser.Username);
                        command.Parameters.AddWithValue("@pass", activeUserPass);
                        command.Parameters.AddWithValue("@id", ActiveUser.Id);

                        command.CommandType = CommandType.Text;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) //Si el lector tiene filas, establecer validUser en verdadero.
                                validUser = true;
                            else //Caso contrario, establecer validUser en falso.
                                validUser = false;
                        }
                    }
                }
            }
            return validUser; //Retornar el resultado.
        }
        public int CreateUser(User user)
        {//Insertar nuevo usuario.
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"insert into empleado 
	                                        values (@nombre_empleado,@nombre_usuario,@contrasenia_usuario,@DUI,@phone,@direction,@email,@estadoEmpleado,@tipoEmpleado,@idhotel)";

                    command.Parameters.AddWithValue("@nombre_empleado", user.FirstName);
                    command.Parameters.AddWithValue("@nombre_usuario", user.Username);
                    command.Parameters.AddWithValue("@contrasenia_usuario", user.Password);
                    command.Parameters.AddWithValue("@DUI", user.DUI);
                    command.Parameters.AddWithValue("@phone", user.Phone);
                    command.Parameters.AddWithValue("@direction", user.Direction);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@estadoEmpleado", user.Estado);
                    command.Parameters.AddWithValue("@tipoEmpleado", user.TipoEmpleado);
                    command.Parameters.AddWithValue("@idhotel", user.IdHotel);
                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery(); //Ejecutar el comando de texto y asignar el resultado al campo result.
                }
            }
            return result;//retornar el numero de filas afectadas de la transaccion. 
        }
        public int ModifyUser(User user)
        {//Actualizar usuario.
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"update  empleado	
	                                        set nombre_usuario=@userName,password=@password,firstName=@firstName,lastName= @lastName,position= @position,email=@email, profilePicture=@photo  
	                                        where id=@id ";
                    command.Parameters.AddWithValue("@userName", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@DUI", user.DUI);
                    command.Parameters.AddWithValue("@position", user.Position);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@estado", user.Estado);
                    command.Parameters.AddWithValue("@tipoempleado", user.TipoEmpleado);
                    command.Parameters.AddWithValue("@idhotel", user.IdHotel);
                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
        public int RemoveUser(int id)
        {//Eliminar usuario.
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"delete from empleado where ID_empleado=@id ";
                    command.Parameters.AddWithValue("@id", id);
                
                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
        public User GetUserById(int id)
        {//Obtener usuario por id.
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from empleado where ID_empleado=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var userObj = new User
                        {
                            Id = (int)reader[0],
                            Username = reader[2].ToString(),
                            Password = reader[3].ToString(),
                            FirstName = reader[1].ToString(),
                            DUI = reader[4].ToString(),
                            Phone = reader[5].ToString(),
                            Direction = reader[6].ToString(),
                            Position = reader[8].ToString(),
                            Email = reader[7].ToString()
                        };
                        return userObj; //Retornar resultado (objeto).
                    }
                    else
                        return null;//Retornar NULL si no hay resultado.
                }
            }
        }
        public User GetUserByUsername(string user, string email)
        {//Obtener usuario por nombre de usuario o email.
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from empleado where nombre_usuario=@user or correo=@email";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@email", email);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var userObj = new User
                        {
                            Id = (int)reader[0],
                            FirstName = reader[1].ToString(),
                            Username = reader[2].ToString(),
                            Password = reader[3].ToString(),
                            DUI = reader[4].ToString(),
                            Phone = reader[5].ToString(),
                            Direction = reader[6].ToString(),
                            Position = reader[8].ToString(),
                            Email = reader[7].ToString()
                        };
                        return userObj;
                    }
                    else
                        return null;
                }
            }
        }
        public IEnumerable<User> GetAllUsers()
        {//Listar usuarios.
            var userList = new List<User>();//Crear lista generica de usuarios.

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from empleado ";
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Agregar los resultados en la lista mientras el lector siga leyendo las filas.
                        {
                            var userObj = new User
                            {
                                Id = (int)reader[0],
                                FirstName = reader[1].ToString(),
                                Username = reader[2].ToString(),
                                Password = reader[3].ToString(),
                                DUI = reader[4].ToString(),
                                Phone = reader[5].ToString(),
                                Direction = reader[6].ToString(),
                                Email = reader[7].ToString(),
                                Position = reader[8].ToString()
                            };
                            userList.Add(userObj);
                        }
                    }
                }
            }
            return userList; //Retornar lista.
        }
    }
}
