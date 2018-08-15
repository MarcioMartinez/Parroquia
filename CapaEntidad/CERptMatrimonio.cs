using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CERptMatrimonio
    {
        public String Parroquia { get; set; }
        public String Empleado { get; set; }   
        public DateTime Fecha { get; set; }
        public String Novio { get; set; }
        public String Novia { get; set; }
        public String Padrino1 { get; set; }
        public String Madrina1 { get; set; }
        public String Padrino2 { get; set; }
        public String Madrina2 { get; set; }
        public DateTime Hoy { get; set; }
        public Byte[] Logo { get; set; }
    }
}
