using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CNSacramento
    {
        CDSacramento objS = new CDSacramento();

        public DataSet ListadoSacramentos()
        {
            return objS.ListadoSacramentos();
        }

        public DataSet ListadoFeligresSexo(int idSexo)
        {
            return objS.ListadoFeligresSexo(idSexo);
        }

        public DataSet ListadoTodoFeligreses()
        {
            return objS.ListadoTodosFeligreses();
        }

        public DataSet ListadoEmpleado()
        {
            return objS.ListadoEmpleado();
        }

        public DataSet ListadoLugar()
        {
            return objS.ListadoLugar();
        }

        public DataSet ListadoRegistroSacramentos()
        {
            return objS.ListadoRegistroSacramentos();
        }

        public int NuevoRegistroSacramento(CESacramento objSacramento)
        {
            return objS.InsertarRegistroSacramento(objSacramento);
        }

        public int RegistroSacramentoPorFeligres(CESacramentoPorFeligres objSacramentoF)
        {
            return objS.InsertarSacramentoPorFeligres(objSacramentoF);
        }

        public int RegistroPadrinoPorFeligres(CEPadrinoPorFeligres objPadrinos)
        {
            return objS.InsertarPadrinoPorFeligres(objPadrinos);
        }
        public int InsertarPadrinoPorFeligresNovios(CEPadrinoPorFeligres objP)
        {
            return objS.InsertarPadrinoPorFeligresNovios(objP);
        }

        public int ActualizarRegistroSacramento(CESacramento objSacramento)
        {
            return objS.ActualizarRegistroSacramento(objSacramento);
        }

        public int ActualizarSacramentoPorFeligres(CESacramentoPorFeligres objSacramentoF)
        {
            return objS.ActualizarSacramentoPorFeligres(objSacramentoF);
        }
        
        public int ActualizarPadrinosPorFeligres(CEPadrinoPorFeligres objPadrinos, String padrinoAnterior)
        {
            return objS.ActualizarPadrinoPorFeligres(objPadrinos, padrinoAnterior);
        }
        public CESacramento ObtenerSacramento(int idRegistro)
        {
            return objS.MostrarUnSacramento(idRegistro);
        }
        public CESacramentoPorFeligres ObtenerFeligresSacramento(int idRegistro)
        {
            return objS.MostrarUnFeligresSacramento(idRegistro);
        }
        public List<CEPadrinoPorFeligres> ObtenerPadrinosFeligres(int idRegistro)
        {
            return objS.MostrarPadrinosFeligres(idRegistro);
        }

        public List<CESacramentoPorFeligres> SeleccionarNoviosMatrimonio(int idRegistro)
        {
            return objS.SeleccionarNovios(idRegistro);
        }

        public bool Existe_Registro(CESacramentoPorFeligres objSF, int idSacramento)
        {
            return objS.ExisteRegistro(objSF, idSacramento);
        }
    }
}
