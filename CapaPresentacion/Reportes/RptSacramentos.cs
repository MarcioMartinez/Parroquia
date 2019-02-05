using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Globalization;

namespace CapaPresentacion.Reportes
{
    public partial class RptSacramentos : DevExpress.XtraReports.UI.XtraReport
    {
        public RptSacramentos(int anio, int mes)
        {
            InitializeComponent();
            txtParroquiaLugar.Text = Funciones.Funciones.nombreParroquia.ToUpper();
            this.sp_Mostrar_Todo_Sacramento_ReporteTableAdapter.Fill(this.dsReportes1.Sp_Mostrar_Todo_Sacramento_Reporte, anio, mes);
            txtHoy.Text = txtHoy.Text.Replace("p16", DateTime.Now.Day.ToString()).Replace("p17", DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))).Replace("p18", DateTime.Now.Year.ToString());
            if (Funciones.Funciones.logo != null && Formularios.FrmPrincipal.usa_logo)
            {
                MemoryStream ms = new MemoryStream((byte[])Funciones.Funciones.logo);
                pbLogo.Image = Image.FromStream(ms);
            }
        }

    }
}
