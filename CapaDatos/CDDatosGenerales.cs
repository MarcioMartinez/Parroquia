using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDDatosGenerales : Conexion
    {
        public int Guardar_Datos_Generales(CEDatosGenerales objDG)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Datos_Generales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Dato", SqlDbType.Int).Value = objDG.Id_Dato;
                cmd.Parameters.Add("@Nombre_Parroquia", SqlDbType.NVarChar, 100).Value = objDG.Nombre_Parroquia;
                cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = objDG.Direccion;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = objDG.Telefono;
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = objDG.Id_Usuario;
                cmd.Parameters.Add("@Logo", SqlDbType.Image).Value = objDG.Logo;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                throw new Exception("Error al almacenar los datos.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public CEDatosGenerales MostrarDatosGenerales()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CEDatosGenerales objD = new CEDatosGenerales();

            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_Datos_Generales", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objD.Id_Dato = int.Parse(dr["Id_Dato"].ToString());
                    objD.Nombre_Parroquia = dr["Nombre_Parroquia"].ToString();
                    objD.Direccion = dr["Direccion"].ToString();
                    objD.Telefono = dr["Telefono"].ToString();
                    objD.Telefono = dr["Telefono"].ToString();
                    objD.Logo = (byte[])dr["Logo"];
                }

                return objD;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al solicitar los datos. ", ex);
            }
            finally
            {
                CerrarBD();
            }
        }
    }
}
