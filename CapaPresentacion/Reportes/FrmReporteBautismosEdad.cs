using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.IO;

namespace CapaPresentacion.Reportes
{
    public partial class FrmReporteBautismosEdad : DevExpress.XtraReports.UI.XtraReport
    {
        public FrmReporteBautismosEdad(int opcion)
        {
            InitializeComponent();
            txtParroquiaLugar.Text = Funciones.Funciones.nombreParroquia.ToUpper();
            this.sp_Mostrar_Todo_Sacramento_Bautismo_ReporteTableAdapter1.Fill(this.dsReportes1.Sp_Mostrar_Todo_Sacramento_Bautismo_Reporte, opcion);
            txtHoy.Text = txtHoy.Text.Replace("p16", DateTime.Now.Day.ToString()).Replace("p17", DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))).Replace("p18", DateTime.Now.Year.ToString());
            if (Funciones.Funciones.logo != null && Formularios.FrmPrincipal.usa_logo)
            {
                MemoryStream ms = new MemoryStream((byte[])Funciones.Funciones.logo);
                pbLogo.Image = Image.FromStream(ms);
            }

            switch (opcion)
            {
                case 0:
                    txtCertificacion.Text = "REPORTE DE BAUTISMOS";
                    break;
                case 1:
                    txtCertificacion.Text = "REPORTE DE BAUTISMOS ( NIÑOS )";
                    break;
                case 2:
                    txtCertificacion.Text = "REPORTE DE BAUTISMOS ( JÓVENES )";
                    break;
                default:
                    txtCertificacion.Text = "REPORTE DE BAUTISMOS ( ADULTOS )";
                    break;
            }
        }

    }
}
