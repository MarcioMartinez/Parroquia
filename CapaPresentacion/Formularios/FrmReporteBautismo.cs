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

namespace CapaPresentacion.Formularios
{
    public partial class FrmReporteBautismo : DevExpress.XtraEditors.XtraForm
    {
        Form padre;
        public FrmReporteBautismo(Form padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void FrmReporteBautismo_Load(object sender, EventArgs e)
        {
            cboAnios.Properties.Items.Add("TODOS");
            cboAnios.Properties.Items.Add("NIÑOS");
            cboAnios.Properties.Items.Add("JÓVENES");
            cboAnios.Properties.Items.Add("ADULTOS");

            cboAnios.SelectedIndex = 0;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteBautismosEdad reporte = new Reportes.FrmReporteBautismosEdad(cboAnios.SelectedIndex);
            Funciones.Funciones.MostrarReportes("Reporte de Bautismos", reporte, padre, false);
            this.Close();
        }
    }
}