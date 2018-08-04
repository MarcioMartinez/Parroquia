using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using DevExpress.XtraPrinting;
using System.Windows.Forms;
using System.Diagnostics;

namespace CapaPresentacion.Funciones
{
    public class Funciones
    {
        public static void ExportarExcel(DevExpress.XtraGrid.GridControl grid, String nombre)
        {
            SaveFileDialog archivo = new SaveFileDialog();
            try
            {
                archivo.Filter = "xls|*.xls";
                archivo.FileName = nombre;
                archivo.ShowDialog();

                if(archivo.FileName.Length > 0)
                {
                    grid.ExportToXls(archivo.FileName);
                    Process.Start(archivo.FileName);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al generar el archivo", ex);
            }
        }
        public static void ExportarPDF(DevExpress.XtraGrid.GridControl grid, String nombre)
        {
            SaveFileDialog archivo = new SaveFileDialog();
            try
            {
                archivo.Filter = "pdf|*.pdf";
                archivo.FileName = nombre;
                archivo.ShowDialog();

                if (archivo.FileName.Length > 0)
                {
                    grid.ExportToPdf(archivo.FileName);
                    Process.Start(archivo.FileName);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al generar el archivo", ex);
            }
        }
    }
}
