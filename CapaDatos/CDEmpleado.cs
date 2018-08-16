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
    public class CDEmpleado: Conexion
    {
        public int InsertarEmpleado(CEEmpleado objE)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Empleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 15).Value = objE.NumeroIdentidad;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = objE.Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 30).Value = objE.Apellido;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = objE.Telefono;
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 100).Value = objE.Direccion;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 30).Value = objE.Correo;
                cmd.Parameters.Add("@IdCargo", SqlDbType.Int).Value = objE.IdCargo;
                cmd.Parameters.Add("@IdSexo", SqlDbType.Int).Value = objE.IdSexo;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = objE.Estado;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de Almacenar el Empleado", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public int ActualizarEmpleado(CEEmpleado objE)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Empleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 15).Value = objE.NumeroIdentidad;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = objE.Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 30).Value = objE.Apellido;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = objE.Telefono;
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 100).Value = objE.Direccion;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 30).Value = objE.Correo;
                cmd.Parameters.Add("@IdCargo", SqlDbType.Int).Value = objE.IdCargo;
                cmd.Parameters.Add("@IdSexo", SqlDbType.Int).Value = objE.IdSexo;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = objE.Estado;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar Actualizar el Empleado", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public int EliminarEmpleado(CEEmpleado objE)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Eliminar_Empleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 15).Value = objE.NumeroIdentidad;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar Eliminar el Empleado", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public DataSet ListadoEmpleado()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todo_Empleado", cn);
                da.Fill(ds, "Empleado");
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
       
        public CEEmpleado MostrarUnEmpleado(String numeroIdentidad)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CEEmpleado objE = new CEEmpleado();
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_Un_Empleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 15).Value = numeroIdentidad;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objE.NumeroIdentidad = dr["Num_Identidad"].ToString();
                    objE.Nombre = dr["Nombre"].ToString();
                    objE.Apellido = dr["Apellido"].ToString();
                    objE.Telefono = dr["Telefono"].ToString();
                    objE.Direccion = dr["Direccion"].ToString();
                    objE.Correo = dr["Correo"].ToString();
                    objE.IdCargo = int.Parse(dr["Id_Cargo"].ToString());
                    objE.IdSexo = int.Parse(dr["Id_Sexo"].ToString());
                    objE.Estado = dr.GetBoolean(8);
                }
                return objE;
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

        public DataSet ListadoCargo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Cargo", cn);
                da.Fill(ds, "Cargo");
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

    }
}
