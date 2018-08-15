using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace CapaPresentacion.Reportes
{
    public partial class FrmModeloReportes : DevExpress.XtraEditors.XtraForm
    {
        public FrmModeloReportes()
        {
            InitializeComponent();
        }

        public Boolean HideToolBars { get; set; }
        private XtraReport FReporte;

        public XtraReport getReporte()
        {
            return FReporte;
        }

        public void setReporte(XtraReport value)
        {
            FReporte = value;
            this.Invalidate();
            this.Update();

            if (HideToolBars)
                this.previewBar1.Visible = HideToolBars;

            documentViewer1.PrintingSystem = FReporte.PrintingSystem;
            documentViewer1.Zoom = float.Parse("0.5");
         
            FReporte.CreateDocument(true);
        }
        private void FrmModeloReportes_Load(object sender, EventArgs e)
        {
           
        }
    }
}