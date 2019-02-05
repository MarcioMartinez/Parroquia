using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;

namespace CapaPresentacion.Formularios
{
    public partial class FrmReporteSacramentos : DevExpress.XtraEditors.XtraForm
    {
        Form padre;
        public FrmReporteSacramentos(Form padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void FrmReporteSacramentos_Load(object sender, EventArgs e)
        {
           for(int i = 2010; i<= DateTime.Today.Year; i++)
            {
                cboAnios.Properties.Items.Add(i);
            }
            cboAnios.SelectedItem = DateTime.Today.Year;

            List<string> names = new List<string>();
            foreach (var item in CultureInfo.CreateSpecificCulture("es").DateTimeFormat.MonthNames)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    names.Add(item.ToUpper());
                }
               
            }
            cboMeses.Properties.Items.AddRange(names);
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
        
            Reportes.RptSacramentos reporte = new Reportes.RptSacramentos(int.Parse(cboAnios.SelectedItem.ToString()), (cboMeses.SelectedIndex + 1));
            Funciones.Funciones.MostrarReportes("Reporte de Sacramentos", reporte, padre, false);
            this.Close();  
        }

        private void cboAnios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}