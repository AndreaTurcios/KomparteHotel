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
    class TipoEmpleadoDao : ConnectionToSql
    {
        public IEnumerable<TipoEmpleado> GetAllTipoEmpleado() {
            var tipoEmpladoList = new List<TipoEmpleado>();

            using (var connection  = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tipo_empleado";
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read()) //Agregar los resultados en la lista 
                        {
                            var estadoEmpleadoObj = new TipoEmpleado
                            {
                                idTipoEmpleado = (int)reader[0],
                                tipoEmpleado = reader[1].ToString()
                            };
                            tipoEmpladoList.Add(estadoEmpleadoObj);
                        }
                    }
                }
            }
                return tipoEmpladoList;
        }
    }
}
