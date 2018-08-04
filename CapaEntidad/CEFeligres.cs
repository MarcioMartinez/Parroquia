using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEFeligres
    {
        public String NumeroIdentidad { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdSexo { get; set; }
        public String NumeroIdentidadPadre { get; set; }
        public String NumeroIdentidadMadre { get; set; }
        public Boolean Estado { get; set; }
    }
}
