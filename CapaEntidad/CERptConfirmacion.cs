using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CERptConfirmacion
    {
        public String Parroquia { get; set; }
        public String Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public String Feligres { get; set; }
        public String Padrino { get; set; }
        public String Madrina { get; set; }
        public DateTime Hoy { get; set; }
        public Byte[] Logo { get; set; }
    }
}
