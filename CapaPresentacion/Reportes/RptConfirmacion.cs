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
    public partial class RptConfirmacion : DevExpress.XtraReports.UI.XtraReport
    {
        public RptConfirmacion(CERptConfirmacion obj)
        {
            InitializeComponent();
            txtLugar.Text = "Parroquia " + obj.Parroquia;
            txtSubtitulo.Text = txtSubtitulo.Text.Replace("p2", obj.Parroquia);
            txtFeligres.Text = obj.Feligres;
            txtFecha.Text = txtFecha.Text.Replace("p4", obj.Fecha.Day.ToString()).Replace("p5", obj.Fecha.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))).Replace("p6", obj.Fecha.Year.ToString());
            txtR1.Rtf = txtR1.Rtf.Replace("p7", obj.Parroquia);
            txtR2.Rtf = txtR2.Rtf.Replace("p8", obj.Empleado);
            txtHoy.Rtf = txtHoy.Rtf.Replace("p9", obj.Hoy.Day.ToString()).Replace("p10", obj.Hoy.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))).Replace("p11", obj.Hoy.Year.ToString());

            if (obj.Padrino.Equals(""))
            {
                lblSiendo.Text = "Siendo su madrina:";
                xrlblPadrino1.Text = obj.Madrina;
                xrlblPadrino2.Text = "";
            }
            else if(obj.Madrina.Equals(""))
            {
                lblSiendo.Text = "Siendo su padrino:";
                xrlblPadrino1.Text = obj.Padrino;
                xrlblPadrino2.Text = "";
            }
            else
            {
                lblSiendo.Text = "Siendo sus padrinos:";
                xrlblPadrino1.Text = obj.Madrina;
                xrlblPadrino2.Text = obj.Padrino;
            }

            if (obj.Logo != null)
            {
                MemoryStream ms = new MemoryStream((byte[])obj.Logo);
                pbLogo.Image = Image.FromStream(ms);
            }
        }

    }
}
