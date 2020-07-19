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
    public class ADOSqlProveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                SqlConnection cn = new ConexionSQL().ObtenerConexion();
                SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_LISTAR", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Proveedor()
                    {
                        IdProveedor = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Direccion = dr.GetString(2),
                        NombreContacto = dr.GetString(3),
                        CargoContacto = dr.GetString(4),
                        IdPais = dr.GetInt32(5),
                        Telefono = dr.GetString(6),
                        Fax = dr.GetString(7)

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




        public int Insertar(Proveedor obj)
        {
            int resultado = -1;
            SqlConnection cn = new ConexionSQL().ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_INSERTAR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@NombreContacto", obj.NombreContacto);
                cmd.Parameters.AddWithValue("@CargoContacto", obj.CargoContacto);
                cmd.Parameters.AddWithValue("@Idpais", obj.IdPais);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Fax", obj.Fax);

                cn.Open();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }



        public Proveedor Obtener(int id)
        {
            Proveedor obj = new Proveedor();
            try
            {
                SqlConnection cn = new ConexionSQL().ObtenerConexion();
                SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_OBTENER", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = new Proveedor()
                    {
                        IdProveedor = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Direccion = dr.GetString(2),
                        NombreContacto = dr.GetString(3),
                        CargoContacto = dr.GetString(4),
                        IdPais = dr.GetInt32(5),
                        Telefono = dr.GetString(6),
                        Fax = dr.GetString(7)
                    };
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }

        public int Actualizar(Proveedor obj)
        {
            int resultado = -1;
            SqlConnection cn = new ConexionSQL().ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_ACTUALIZAR", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@NombreContacto", obj.NombreContacto);
                cmd.Parameters.AddWithValue("@CargoContacto", obj.CargoContacto);
                cmd.Parameters.AddWithValue("@Idpais", obj.IdPais);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Fax", obj.Fax);
                cmd.Parameters.AddWithValue("@Id", obj.IdProveedor);

                cn.Open();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public int Eliminar(int id)
        {
            int resultado = -1;
            SqlConnection cn = new ConexionSQL().ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_ELIMINAR", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
    }
}
