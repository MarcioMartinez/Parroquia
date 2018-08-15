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
    public class CDCargo : Conexion
    {
        public int InsertarCargo(CECargo objC)
        {
            int resultado = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Cargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 15).Value = objC.Cargo;


                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el cargo.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int ActualizarCargo(CECargo objC)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Cargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCargo", SqlDbType.Int).Value = objC.IdCargo;
                cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 15).Value = objC.Cargo;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                throw new Exception("Error al tratar de actualizar el cargo.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int EliminarCargo(CECargo objC)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Eliminar_Cargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCargo", SqlDbType.Int).Value = objC.IdCargo;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }catch(Exception ex)
            {
                throw new Exception("Error al tratar de eliminar el feligres", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }
        public DataSet ListadoCargo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todo_Cargo", cn);
                da.Fill(ds, "Cargo");
                return ds;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al solicitar los datos", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public CECargo MostrarUnCargo(int idCargo)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CECargo objCargo = new CECargo();
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_Un_Cargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCargo", SqlDbType.Int).Value = idCargo;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objCargo.IdCargo = int.Parse(dr["Id_Cargo"].ToString());
                    objCargo.Cargo = dr["Cargo"].ToString();
                }

                return objCargo;
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
