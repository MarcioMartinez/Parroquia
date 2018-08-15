using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CESacramento
    {
        public int Id_Registro_Sacramento { get; set; }
        public int Id_Sacramento { get; set; }
        public DateTime Fecha { get; set; }
        public String Num_Identidad { get; set; }
        public int Id_Lugar { get; set; }
        public int Numero_Libro { get; set; }
        public int Numero_Pagina { get; set; }
        public int Numero_Acta { get; set; }
        public int Id_Usuario { get; set; }
    }
}
