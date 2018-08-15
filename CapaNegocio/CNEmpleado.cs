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
    public class CNEmpleado
    {
        CDEmpleado objE = new CDEmpleado();

        public int NuevoEmpleado(CEEmpleado objEmpleado)
        {
            return objE.InsertarEmpleado(objEmpleado);
        }
        public int ActualizarEmpleado(CEEmpleado objEmpleado)
        {
            return objE.ActualizarEmpleado(objEmpleado);
        }
        public int EliminarEmpleado(CEEmpleado objEmpleado)
        {
            return objE.EliminarEmpleado(objEmpleado);
        }
        public DataSet ListadoEmpleado()
        {
            return objE.ListadoEmpleado();
        }
        public DataSet ListadoSexo()
        {
            return objE.ListadoSexo();
        }

        public DataSet ListadoCargo()
        {
            return objE.ListadoCargo();
        }
        public CEEmpleado ObtenerEmpleado(String numeroIdentidad)
        {
            return objE.MostrarUnEmpleado(numeroIdentidad);
        }
    }
}
