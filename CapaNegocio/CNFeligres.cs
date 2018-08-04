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
    public class CNFeligres
    {
        CDFeligres objF = new CDFeligres();

        public int NuevoFeligres(CEFeligres objFeligres)
        {
            return objF.InsertarFeligres(objFeligres);
        }
        public int ActualizarFeligres(CEFeligres objFeligres)
        {
            return objF.ActualizarFeligres(objFeligres);
        }
        public int EliminarFeligres(CEFeligres objFeligres)
        {
            return objF.EliminarFeligres(objFeligres);
        }
        public DataSet ListadoFeligres()
        {
            return objF.ListadoFeligres();
        }
        public DataSet ListadoSexo()
        {
            return objF.ListadoSexo();
        }
        public DataSet ListadoFeligresSexo(int idSexo)
        {
            return objF.ListadoFeligresSexo(idSexo);
        }
        public CEFeligres ObtenerFeligres(String numeroIdentidad)
        {
            return objF.MostrarUnFeligres(numeroIdentidad);
        }
    }
}
