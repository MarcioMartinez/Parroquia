﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using CapaEntidad;
using System.Globalization;

namespace CapaPresentacion.Reportes
{
    public partial class RptMatrimonio : DevExpress.XtraReports.UI.XtraReport
    {
        public RptMatrimonio(CERptMatrimonio obj)
        {
            InitializeComponent();
            txtLugar.Text = "Parroquia " + obj.Parroquia;
            txtLugar2.Text = "Parroquia " + obj.Parroquia;
            txtSubtitulo.Text = txtSubtitulo.Text.Replace("p2", obj.Parroquia);
            txtEmp.Text = txtEmp.Text.Replace("p1", obj.Empleado);
            txtNovia.Text = obj.Novia;
            txtNovio.Text = obj.Novio;
            txtMadrinaNovia.Text = obj.Madrina1;
            txtMadrinaNovio.Text = obj.Madrina2;
            txtPadrinoNovia.Text = obj.Padrino1;
            txtPadrinoNovio.Text = obj.Padrino2;
            txtFecha.Text = obj.Fecha.Day.ToString() + " de " + obj.Fecha.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")) + " del " + obj.Fecha.Year.ToString();
            txtHoy.Rtf = txtHoy.Rtf.Replace("p9", obj.Hoy.Day.ToString()).Replace("p10", obj.Hoy.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))).Replace("p11", obj.Hoy.Year.ToString());
        }

    }
}
