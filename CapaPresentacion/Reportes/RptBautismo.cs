using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using CapaEntidad;
using System.Globalization;
using System.IO;

namespace CapaPresentacion.Reportes
{
    public partial class RptBautismo : DevExpress.XtraReports.UI.XtraReport
    {
        CERptBautismo objx;
        public RptBautismo(CERptBautismo obj)
        {
            InitializeComponent();
            objx = obj;
        }

        private void RptBautismo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            txtParroquiaLugar.Text = Funciones.Funciones.nombreParroquia.ToUpper();
            txtCertificacion.Text = "CERTIFICACIÓN DE " + objx.Sacramento.ToUpper();
            txtR2.Text = txtR2.Text.Replace("p0", Funciones.Funciones.nombreParroquia);
            txtR3.Rtf = txtR3.Rtf.Replace("p1", objx.NumeroBautismo);
            txtR3.Rtf = txtR3.Rtf.Replace("p2", objx.NumeroPagina);
            txtR3.Rtf = txtR3.Rtf.Replace("p3", objx.BajoNumero);
            txtR4.Rtf = txtR4.Rtf.Replace("p4", objx.Parroquia);
            txtR4.Rtf = txtR4.Rtf.Replace("p5", objx.Fecha.Day.ToString());
            txtR4.Rtf = txtR4.Rtf.Replace("p6", objx.Fecha.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")));
            txtR4.Rtf = txtR4.Rtf.Replace("p7", objx.Fecha.Year.ToString());
            txtR5.Rtf = txtR5.Rtf.Replace("p19", objx.Empleado);
            txtR6.Text = objx.Feligres;
            txtR7.Rtf = txtR7.Rtf.Replace("p9", objx.FechaNacimiento.Day.ToString()).Replace("p10", objx.FechaNacimiento.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))).Replace("p11", objx.FechaNacimiento.Year.ToString());


            if (objx.Padre.Trim().Equals("") && objx.Madre.Trim().Equals(""))
            {
                txtPP2.Visible = false;
                xrlblPadre2.Visible = false;
                txtpp1.Visible = false;
                xrlblPadre2.Visible = false;
            }
            if (objx.Padre.Trim().Equals("")){
                txtPP2.Visible = false;
                xrlblPadre2.Visible = false;
                xrlblPadre1.Text = objx.Madre;
            }
            else if (objx.Madre.Trim().Equals(""))
            {
                txtPP2.Visible = false;
                xrlblPadre2.Visible = false;
                xrlblPadre1.Text = objx.Padre;
            }
            else
            {
                xrlblPadre1.Text = objx.Padre;
                xrlblPadre2.Text = objx.Madre;
            }

            txtR8.Rtf = txtR8.Rtf.Replace("p14", objx.Madrina).Replace("p15", objx.Padrino);
            txtHoy.Text = txtHoy.Text.Replace("p16", objx.Hoy.Day.ToString()).Replace("p17", objx.Hoy.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))).Replace("p18", objx.Hoy.Year.ToString());
            if (objx.Logo != null)
            {
                MemoryStream ms = new MemoryStream((byte[])objx.Logo);
                pbLogo.Image = Image.FromStream(ms);
            }
        }
    }
}
