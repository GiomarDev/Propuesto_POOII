﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.ADOSqlServer
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
