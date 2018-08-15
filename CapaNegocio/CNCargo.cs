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
    public class CNCargo
    {
        CDCargo objC = new CDCargo();

        public int NuevoCargo(CECargo objCargo)
        {
            return objC.InsertarCargo(objCargo);
        }

        public int ActualizarCargo(CECargo objCargo)
        {
            return objC.ActualizarCargo(objCargo);
        }

        public DataSet ListadoCargo()
        {
            return objC.ListadoCargo();
        }

        public CECargo ObtenerCargo(int idCargo)
        {
            return objC.MostrarUnCargo(idCargo);
        }

        public int ElimarCargo(CECargo objCargo)
        {
            return objC.EliminarCargo(objCargo);
        }
    }
}
