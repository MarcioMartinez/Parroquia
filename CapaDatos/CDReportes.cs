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
        public CERptBautismo MostrarReporteBautismo(int idRegistro)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CERptBautismo objRptBautimos = new CERptBautismo();

            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Reporte_Bautismo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = idRegistro;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objRptBautimos = new CERptBautismo()
                    {
                        Parroquia = dr["Lugar"].ToString(),
                        Empleado = dr["Empleado"].ToString(),
                        Sacramento = dr["Sacramento"].ToString(),
                        NumeroBautismo = dr["Numero_Libro"].ToString(),
                        NumeroPagina = dr["Numero_Pagina"].ToString(),
                        BajoNumero = dr["Numero_Acta"].ToString(),
                        Fecha = DateTime.Parse(dr["Fecha"].ToString()),
                        Feligres = dr["Feligres"].ToString(),
                        FechaNacimiento = DateTime.Parse(dr["Fecha_Nacimiento"].ToString()),
                        Padre = dr["Padre"].ToString(),
                        Madre = dr["Madre"].ToString(),
                        Padrino = dr["Padrino"].ToString(),
                        Madrina = dr["Madrina"].ToString(),
                        Hoy = DateTime.Parse(dr["Hoy"].ToString()),
                        Logo = dr.GetBoolean(14) ? (byte[])dr["Logo"] : null,
                        NotaMarginal = dr["Nota_Marginal"] == null ? "" : dr["Nota_Marginal"].ToString()
                    };
                }

                return objRptBautimos;
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
        public CERptConfirmacion MostrarReporteConfirmacion(int idRegistro)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CERptConfirmacion objRptBautimos = new CERptConfirmacion();

            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Reporte_Confirmacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = idRegistro;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objRptBautimos = new CERptConfirmacion()
                    {
                        Parroquia = dr["Lugar"].ToString(),
                        Empleado = dr["Empleado"].ToString(),
                        Fecha = DateTime.Parse(dr["Fecha"].ToString()),
                        Feligres = dr["Feligres"].ToString(),
                        Padrino = dr["Padrino"].ToString(),
                        Madrina = dr["Madrina"].ToString(),
                        Hoy = DateTime.Parse(dr["Hoy"].ToString()),
                        Logo = dr.GetBoolean(7) ? (byte[])dr["Logo"] : null
                    };
                }

                return objRptBautimos;
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
