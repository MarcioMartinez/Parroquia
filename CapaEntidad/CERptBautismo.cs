using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CERptBautismo
    {
        public String Parroquia { get; set; }
        public String Empleado { get; set; }
        public String Sacramento { get; set; }
        public String NumeroBautismo { get; set; }
        public String NumeroPagina { get; set; }
        public String BajoNumero { get; set; }
        public DateTime Fecha { get; set; }
        public String Feligres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Padre { get; set; }
        public String Madre { get; set; }
        public String Padrino { get; set; }
        public String Madrina { get; set; }
        public DateTime Hoy { get; set; }
        public Byte[] Logo { get; set; }
    }
}
