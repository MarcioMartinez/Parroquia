using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEDatosGenerales
    {
        public int Id_Dato { get; set; }
        public String Nombre_Parroquia { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public int Id_Usuario { get; set; }
        public Byte[] Logo { get; set; }
        public Boolean Usa_Logo { get; set; }
    }
}
