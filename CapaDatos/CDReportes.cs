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
    public class CDReportes : Conexion
    {
        public CERptMatrimonio MostrarReporteMatrimonio(int idRegistroSacramento)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CERptMatrimonio obj = new CERptMatrimonio();

            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Reporte_Matrimonio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdSacramento", SqlDbType.Int).Value = idRegistroSacramento;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    obj = new CERptMatrimonio()
                    {
                        Parroquia = dr["Lugar"].ToString(),
                        Fecha = dr.GetDateTime(2),
                        Hoy = DateTime.Today,
                        Empleado = dr["Empleado"].ToString(),
                        Novio = dr["Novio"].ToString(),
                        Novia = dr["Novia"].ToString(),
                        Padrino1 = dr["Padrino_Novia"].ToString(),
                        Madrina1 = dr["Madrina_Novia"].ToString(),
                        Padrino2 = dr["Padrino_Novio"].ToString(),
                        Madrina2 = dr["Madrina_Novio"].ToString(),
                        Logo = dr.GetBoolean(9) ? (byte []) dr["Logo"] : null
                };
                }

                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos. ", ex);
            }
            finally
            {
                CerrarBD();
            }
        }

        public CERptPrimeraComunion MostrarReportePrimeraComunion(int idRegistroSacramento)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CERptPrimeraComunion obj = new CERptPrimeraComunion();

            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Reporte_Primera_Comunion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdSacramento", SqlDbType.Int).Value = idRegistroSacramento;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    obj = new CERptPrimeraComunion()
                    {
                        Parroquia = dr["Lugar"].ToString(),
                        Fecha = dr.GetDateTime(2),
                        Hoy = DateTime.Today,
                        Empleado = dr["Empleado"].ToString(),
                        Feligres = dr["Feligres"].ToString(),
                        Logo = dr.GetBoolean(4) ? (byte[]) dr["Logo"] : null
                    };
                }

                return obj;
            }
            catch (Exception ex)
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
