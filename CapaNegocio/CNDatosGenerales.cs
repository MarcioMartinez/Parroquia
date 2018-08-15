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
    public class CNDatosGenerales
    {
        CDDatosGenerales objD = new CDDatosGenerales();

        public int Guardar_Datos_Generales(CEDatosGenerales objDG)
        {
            return objD.Guardar_Datos_Generales(objDG);
        }

        public CEDatosGenerales Mostrar_Datos()
        {
            return objD.MostrarDatosGenerales();
        }
    }
}
