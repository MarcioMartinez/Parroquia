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
    public class CNLugar
    {
        CDLugar objC = new CDLugar();

        public int NuevoLugar(CELugar objLugar)
        {
            return objC.InsertarLugar(objLugar);
        }

        public int ActualizarLugar(CELugar objLugar)
        {
            return objC.ActualizarLugar(objLugar);
        }

        public DataSet ListadoLugar()
        {
            return objC.ListadoLugar();
        }

        public CELugar ObtenerLugar(int idLugar)
        {
            return objC.MostrarUnLugar(idLugar);
        }

        public int ElimarLugar(CELugar objLugar)
        {
            return objC.EliminarLugar(objLugar);
        }
    }
}
