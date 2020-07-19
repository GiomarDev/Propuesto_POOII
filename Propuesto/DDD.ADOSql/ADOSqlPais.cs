using DDD.ADOSqlServer.Util;
using DDD.Entidadess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.ADOSql
{
    public class ADOSqlPais
    {
        public List<Pais> Listar()
        {
            List<Pais> lista = new List<Pais>();

            try
            {
                SqlConnection cn = new ConexionSQL().ObtenerConexion();
                SqlCommand cmd = new SqlCommand("SP_PAIS_LISTAR", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Pais()
                    {
                        IdPais = dr.GetInt32(0),
                        Nombre = dr.GetString(1)
                    });
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}
