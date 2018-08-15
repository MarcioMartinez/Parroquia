﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDLugar: Conexion
    {
        public int InsertarLugar(CELugar objC)
        {
            int resultado = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Lugar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Lugar", SqlDbType.VarChar, 15).Value = objC.Lugar;


                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el Lugar.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int ActualizarLugar(CELugar objC)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Lugar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdLugar", SqlDbType.Int).Value = objC.Id_Lugar;
                cmd.Parameters.Add("@Lugar", SqlDbType.VarChar, 15).Value = objC.Lugar;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de actualizar el Lugar.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int EliminarLugar(CELugar objC)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Eliminar_Lugar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdLugar", SqlDbType.Int).Value = objC.Id_Lugar;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de eliminar el Lugar", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }
        public DataSet ListadoLugar()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todo_Lugar", cn);
                da.Fill(ds, "Lugar");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public CELugar MostrarUnLugar(int idLugar)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CELugar objLugar = new CELugar();
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_Un_Lugar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdLugar", SqlDbType.Int).Value = idLugar;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objLugar.Id_Lugar = int.Parse(dr["Id_Lugar"].ToString());
                    objLugar.Lugar = dr["Lugar"].ToString();
                }

                return objLugar;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos", ex);
            }
            finally
            {
                CerrarBD();
            }
        }
    }
}
