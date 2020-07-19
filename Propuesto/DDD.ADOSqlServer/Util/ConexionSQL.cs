using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
// Referencias
using System.Configuration;
using System.Data.SqlClient;

namespace DDD.ADOSqlServer.Util
{
    public class ConexionSQL
    {

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["CNX"].ConnectionString);
        }
    }
}

