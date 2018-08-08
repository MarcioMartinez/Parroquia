using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDFeligres : Conexion
    {
        public int InsertarFeligres(CEFeligres objF)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Feligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 15).Value = objF.NumeroIdentidad;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = objF.Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 30).Value = objF.Apellido;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 30).Value = objF.Correo;
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 100).Value = objF.Direccion;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = objF.Telefono;
                cmd.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = objF.FechaNacimiento;
                cmd.Parameters.Add("@IdSexo", SqlDbType.Int).Value = objF.IdSexo;
                if (String.IsNullOrEmpty(objF.NumeroIdentidadPadre.Trim()))
                {
                    cmd.Parameters.Add("@Num_Padre", SqlDbType.Char, 15).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Num_Padre", SqlDbType.Char, 15).Value = objF.NumeroIdentidadPadre;
                }
                if (String.IsNullOrEmpty(objF.NumeroIdentidadMadre.Trim()))
                {
                    cmd.Parameters.Add("@Num_Madre", SqlDbType.Char, 15).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Num_Madre", SqlDbType.Char, 15).Value = objF.NumeroIdentidadMadre;
                }
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = objF.Estado;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el feligres", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public int ActualizarFeligres(CEFeligres objF)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Feligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 15).Value = objF.NumeroIdentidad;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = objF.Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 30).Value = objF.Apellido;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = objF.Telefono;
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 100).Value = objF.Direccion;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 30).Value = objF.Correo;
                cmd.Parameters.Add("@IdSexo", SqlDbType.Int).Value = objF.IdSexo;
                cmd.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = objF.FechaNacimiento;
                if (String.IsNullOrEmpty(objF.NumeroIdentidadPadre.Trim()))
                {
                    cmd.Parameters.Add("@Num_Identidad_Padre", SqlDbType.Char, 15).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Num_Identidad_Padre", SqlDbType.Char, 15).Value = objF.NumeroIdentidadPadre;
                }
                if (String.IsNullOrEmpty(objF.NumeroIdentidadMadre.Trim()))
                {
                    cmd.Parameters.Add("@Num_Identidad_Madre", SqlDbType.Char, 15).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Num_Identidad_Madre", SqlDbType.Char, 15).Value = objF.NumeroIdentidadMadre;
                }
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = objF.Estado;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de actualizar el feligres", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public int EliminarFeligres(CEFeligres objF)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Eliminar_Feligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 15).Value = objF.NumeroIdentidad;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de eliminar el feligres", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public DataSet ListadoFeligres()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todo_Feligres", cn);
                da.Fill(ds, "Feligres");
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
        public DataSet ListadoSexo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Sexo", cn);
                da.Fill(ds, "Sexo");
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
        public DataSet ListadoFeligresSexo(int idSexo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da= new SqlDataAdapter("Sp_Feligres_Sexo", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdSexo", SqlDbType.Int).Value = idSexo;
                da.Fill(ds, "Feligres");
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
        public CEFeligres MostrarUnFeligres(String numeroIdentidad)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CEFeligres objFeligres = new CEFeligres();
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_UnFeligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NumeroIdentidad", SqlDbType.Char, 15).Value = numeroIdentidad;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objFeligres.NumeroIdentidad = dr["Num_Identidad"].ToString();
                    objFeligres.Nombre = dr["Nombre"].ToString();
                    objFeligres.Apellido = dr["Apellido"].ToString();
                    objFeligres.Direccion = dr["Direccion"].ToString();
                    objFeligres.Correo = dr["Correo"].ToString();
                    objFeligres.Telefono = dr["Telefono"].ToString();
                    objFeligres.FechaNacimiento = dr.GetDateTime(6);
                    objFeligres.IdSexo = int.Parse(dr["Id_Sexo"].ToString());
                    objFeligres.NumeroIdentidadPadre = dr["Num_Identidad_Padre"].ToString();
                    objFeligres.NumeroIdentidadMadre = dr["Num_Identidad_Madre"].ToString();
                    objFeligres.Estado = dr.GetBoolean(10);
                }
                return objFeligres;
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
