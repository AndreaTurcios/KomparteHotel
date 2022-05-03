using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komparte.Class;
using Komparte.classes.entidades;
using System.Data;
using System.Data.SqlClient;

namespace Komparte.classes.entidades
{
    class ServicioDao : ConnectionToSql
    {
        public IEnumerable<Servicio> get_all_servicio()
        {
            var servicioList = new List<Servicio>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from servicio";
                    //command.CommandType = CommandType.StoredProcedure;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) //Agregar los resultados en la lista 
                        {
                            var obj = new Servicio
                            {
                                id = (int)reader[0],
                                servicio = reader[1].ToString()
                            };
                            servicioList.Add(obj);
                        }
                    }

                }
            }
            return servicioList;
        }
    }
}
