using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CapaDatos
{
    public class CDSacramento : Conexion
    {
        public DataSet ListadoSacramentos()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Sacramentos", cn);
                da.Fill(ds, "Sacramentos");
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
                da = new SqlDataAdapter("Sp_Feligres_Sexo", cn);
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

        public DataSet ListadoFeligresSexo2(int idSexo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Feligres_Sexo2", cn);
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

        public bool ExisteRegistro(CESacramentoPorFeligres objS, int idSacramento)
        {
            SqlCommand cmd;            

            try
            {
                cmd = new SqlCommand("Sp_Existe_Sacramento_Feligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Sacramento", SqlDbType.Int).Value = idSacramento;
                cmd.Parameters.Add("@Feligres_Num_Identidad", SqlDbType.Char, 15).Value = objS.Feligres_Num_Identidad;

                ConectarBD();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                    return false;
                else
                    return true;                
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
        public DataSet ListadoTodosFeligreses()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todos_Feligreses", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "ListadoFeligres");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos ", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoRegistroSacramentos()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todo_Sacramento", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "ListadoRegistroSacramentos");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos ", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoEmpleado()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter("Sp_Listar_Empleado_Sacramento", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "Empleados");

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro al solicitar los datos ", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoLugar()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter("Sp_Listar_Lugar_Sacramento", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "Lugar");

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro al solicitar los datos ", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public int InsertarRegistroSacramento(CESacramento objS)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Registro_Sacramento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Sacramento", SqlDbType.Int).Value = objS.Id_Sacramento;
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = objS.Fecha;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 15).Value = objS.Num_Identidad;
                cmd.Parameters.Add("@Id_Lugar", SqlDbType.Int).Value = objS.Id_Lugar;
                cmd.Parameters.Add("@Numero_Libro", SqlDbType.Int).Value = objS.Numero_Libro;
                cmd.Parameters.Add("@Numero_Pagina", SqlDbType.Int).Value = objS.Numero_Pagina;
                cmd.Parameters.Add("@Numero_Acta", SqlDbType.Int).Value = objS.Numero_Acta;
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = objS.Id_Usuario;
                cmd.Parameters.Add("@Nota_Marginal", SqlDbType.NVarChar).Value = objS.Nota_Marginal;

                ConectarBD();
                resultado = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el registro de sacramento", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int ActualizarRegistroSacramento(CESacramento objS)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_RegistroSacramento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = objS.Id_Registro_Sacramento;
                cmd.Parameters.Add("@Id_Sacramento", SqlDbType.Int).Value = objS.Id_Sacramento;
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = objS.Fecha;
                cmd.Parameters.Add("@Num_Identidad", SqlDbType.Char, 20).Value = objS.Num_Identidad;
                cmd.Parameters.Add("@Id_Lugar", SqlDbType.Int).Value = objS.Id_Lugar;
                cmd.Parameters.Add("@Numero_Libro", SqlDbType.Int).Value = objS.Numero_Libro;
                cmd.Parameters.Add("@Numero_Pagina", SqlDbType.Int).Value = objS.Numero_Pagina;
                cmd.Parameters.Add("@Numero_Acta", SqlDbType.Int).Value = objS.Numero_Acta;
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = objS.Id_Usuario;
                cmd.Parameters.Add("@Nota_Marginal", SqlDbType.NVarChar).Value = objS.Nota_Marginal;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el registro de sacramento", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int InsertarSacramentoPorFeligres(CESacramentoPorFeligres objS)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Sacramento_Por_Feligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = objS.Id_Registro_Sacramento;
                cmd.Parameters.Add("@Feligres_Num_Identidad", SqlDbType.Char, 15).Value = objS.Feligres_Num_Identidad;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el registro.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int ActualizarSacramentoPorFeligres(CESacramentoPorFeligres objS)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Sacramento_Por_Feligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = objS.Id_Registro_Sacramento;
                cmd.Parameters.Add("@Feligres_Num_Identidad", SqlDbType.Char, 15).Value = objS.Feligres_Num_Identidad;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el registro.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }
        public int InsertarPadrinoPorFeligres(CEPadrinoPorFeligres objP)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Padrino_Por_Sacramento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = objP.Id_Registro_Sacramento;
                cmd.Parameters.Add("@Feligres_Num_Identidad", SqlDbType.Char, 15).Value = objP.Feligres_Num_Identidad;
                cmd.Parameters.Add("@De_Novio", SqlDbType.Bit).Value = objP.De_Novio;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el registro.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }
        public int InsertarPadrinoPorFeligresNovios(CEPadrinoPorFeligres objP)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Padrino_Por_Sacramento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = objP.Id_Registro_Sacramento;
                cmd.Parameters.Add("@Feligres_Num_Identidad", SqlDbType.Char, 15).Value = objP.Feligres_Num_Identidad;
                cmd.Parameters.Add("@De_Novio", SqlDbType.Bit).Value = objP.De_Novio;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el registro.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }
        public int ActualizarPadrinoPorFeligres(CEPadrinoPorFeligres objP, String padrinoAnterior)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Padrinos_Feligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = objP.Id_Registro_Sacramento;
                cmd.Parameters.Add("@Feligres_Num_Identidad", SqlDbType.Char, 15).Value = objP.Feligres_Num_Identidad;
                cmd.Parameters.Add("@Feligres_Num_Identidad_Anterior", SqlDbType.Char, 15).Value = padrinoAnterior;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el registro.", ex);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public CESacramento MostrarUnSacramento(int Id_Registro_Sacramento)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CESacramento objSacramento = new CESacramento();

            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_Un_Sacramento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = Id_Registro_Sacramento;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objSacramento.Id_Registro_Sacramento = int.Parse(dr["Id_Registro_Sacramento"].ToString());
                    objSacramento.Id_Sacramento = int.Parse(dr["Id_Sacramento"].ToString());
                    objSacramento.Fecha = dr.GetDateTime(2);
                    objSacramento.Num_Identidad = dr["Num_Identidad"].ToString();
                    objSacramento.Id_Lugar = int.Parse(dr["Id_Lugar"].ToString());
                    objSacramento.Numero_Libro = int.Parse(dr["Numero_Libro"].ToString());
                    objSacramento.Numero_Pagina = int.Parse(dr["Numero_Pagina"].ToString());
                    objSacramento.Numero_Acta = int.Parse(dr["Numero_Acta"].ToString());
                    objSacramento.Nota_Marginal = dr["Nota_Marginal"].ToString();
                }
                return objSacramento;
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
        public CESacramentoPorFeligres MostrarUnFeligresSacramento(int Id_Registro_Sacramento)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CESacramentoPorFeligres objSacramentoFeligres = new CESacramentoPorFeligres();

            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_Feligres_Sacramento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = Id_Registro_Sacramento;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objSacramentoFeligres.Id_Registro_Sacramento = int.Parse(dr["Id_Registro_Sacramento"].ToString());
                    objSacramentoFeligres.Feligres_Num_Identidad = dr["Feligres_Num_Identidad"].ToString();
                }
                return objSacramentoFeligres;
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

        public List<CEPadrinoPorFeligres> MostrarPadrinosFeligres(int Id_Registro_Sacramento)
        {
            SqlCommand cmd;
            SqlDataReader dr;

            CEPadrinoPorFeligres objPadrinoFeligres = new CEPadrinoPorFeligres();
            CEPadrinoPorFeligres objMadrinaFeligres = new CEPadrinoPorFeligres();
            List<CEPadrinoPorFeligres> lista = new List<CEPadrinoPorFeligres>();
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_Padrinos_Feligres", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = Id_Registro_Sacramento;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CEPadrinoPorFeligres objPadrinos = new CEPadrinoPorFeligres();
                    objPadrinos.Id_Registro_Sacramento = int.Parse(dr.GetValue(0).ToString());
                    objPadrinos.Feligres_Num_Identidad = dr["Feligres_Num_Identidad"].ToString();
                    objPadrinos.De_Novio = dr.GetBoolean(2);
                    lista.Add(objPadrinos);
                }
                return lista;
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
        public List<CESacramentoPorFeligres> SeleccionarNovios(int Id_Registro_Sacramento)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            
            List<CESacramentoPorFeligres> lista = new List<CESacramentoPorFeligres>();
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Seleccionar_Novios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Registro_Sacramento", SqlDbType.Int).Value = Id_Registro_Sacramento;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CESacramentoPorFeligres objNovios = new CESacramentoPorFeligres();
                    objNovios.Id_Registro_Sacramento = int.Parse(dr.GetValue(0).ToString().Trim());
                    objNovios.Feligres_Num_Identidad = dr.GetValue(1).ToString().Trim();
                    lista.Add(objNovios);
                }
                return lista;
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
