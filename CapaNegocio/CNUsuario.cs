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
    public class CNUsuario
    {
        CDUsuario objF = new CDUsuario();

        public int NuevoUsuario(CEUsuario objUsuario)
        {
            return objF.InsertarUsuario(objUsuario);
        }
        public int ActualizarUsuario(CEUsuario objUsuario)
        {
            return objF.ActualizarUsuario(objUsuario);
        }
        public DataSet ListadoUsuario()
        {
            return objF.ListadoUsuario();
        }
        public DataSet ListadoEmpleado()
        {
            return objF.ListadoEmpleado();
        }
        public CEUsuario ObtenerUsuario(int IdUsuario)
        {
            return objF.MostrarUnUsuario(IdUsuario);
        }
    }
}
