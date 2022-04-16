using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Komparte.Class
{
    public abstract class ConnectionToSql
    {
        /// <summary>
        /// Esta clase abstracta es responsable de establecer la cadena de conexion
        /// y obtener la conexion a SQL.
        /// </summary>
        /// 

        private readonly string connectionStringAndrea;//Obtiene o establece la cadena de conexión.
        private readonly string connectionStringErick;//Obtiene o establece la cadena de conexión.

        public ConnectionToSql()
        {
            //Establecer la cadena de conexión.
            //connectionStringAndrea = "Server=LAPTOP-ANDREA; DataBase= dbkomparte; Integrated Security= true";
            connectionStringErick = "Server=DESKTOP-HPNEI9A\\SQLEXPRESS; DataBase= dbkomparte; Integrated Security= true";
        }
        protected SqlConnection GetConnection()
        {
            //Este métedo se encarga de establecer y devolver el objeto de conexión a SQL Server.
            return new SqlConnection(connectionStringErick);
        }
    }
}
