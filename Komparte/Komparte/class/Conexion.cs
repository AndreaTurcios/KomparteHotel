using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Komparte.Class
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection cn = new SqlConnection("SERVER=LAPTOP-ANDREA;DATABASE=dbkomparte;integrated security=true;");
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                //throw new Exception("Error en la conexion");
                return null;
            }
        }
    }
}
