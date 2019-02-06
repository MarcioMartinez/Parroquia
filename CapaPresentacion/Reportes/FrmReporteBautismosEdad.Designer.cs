namespace CapaPresentacion.Reportes
{
    partial class FrmReporteBautismosEdad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteBautismosEdad));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.pbLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txtParroquiaLugar = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCertificacion = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sp_Mostrar_Todo_Sacramento_ReporteTableAdapter = new CapaPresentacion.ConjuntoDatos.DsReportesTableAdapters.Sp_Mostrar_Todo_Sacramento_ReporteTableAdapter();
            this.dsReportes1 = new CapaPresentacion.ConjuntoDatos.DsReportes();
            this.sp_Mostrar_Todo_Sacramento_Bautismo_ReporteTableAdapter1 = new CapaPresentacion.ConjuntoDatos.DsReportesTableAdapters.Sp_Mostrar_Todo_Sacramento_Bautismo_ReporteTableAdapter();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.txtHoy = new DevExpress.XtraReports.UI.XRRichText();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.BorderWidth = 1F;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(1.589457E-05F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(742.9999F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell14});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 11.5D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Sp_Mostrar_Todo_Sacramento_Bautismo_Reporte.NombreCompleto")});
            this.xrTableCell8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F);
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.Weight = 0.54816559322882075D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Sp_Mostrar_Todo_Sacramento_Bautismo_Reporte.Fecha", "{0:d/M/yyyy}")});
            this.xrTableCell11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.Weight = 0.1538508878321122D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Sp_Mostrar_Todo_Sacramento_Bautismo_Reporte.Lugar")});
            this.xrTableCell12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F);
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.Weight = 0.2511392734671361D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.BorderWidth = 1F;
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Sp_Mostrar_Todo_Sacramento_Bautismo_Reporte.Edad")});
            this.xrTableCell14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F);
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseBorderWidth = false;
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UsePadding = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell14.Weight = 0.27785000371249025D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrLine5,
            this.pbLogo,
            this.xrPictureBox1,
            this.txtParroquiaLugar,
            this.XrLabel27,
            this.txtCertificacion});
            this.TopMargin.HeightF = 299.6666F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderWidth = 1F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 274.6666F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(742.9999F, 25F);
            this.xrTable1.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UseBorders = false;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Feligres";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell1.Weight = 1.7811959781384343D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Fecha";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell2.Weight = 0.49991932523730959D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BorderWidth = 1F;
            this.xrTableCell3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorderWidth = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Lugar";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell3.Weight = 0.81604533603009655D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Edad";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell4.Weight = 0.90283936059415892D;
            // 
            // xrLine5
            // 
            this.xrLine5.LineWidth = 2;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 225.1666F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(742.9999F, 3.041656F);
            // 
            // pbLogo
            // 
            this.pbLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 53.31262F);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.SizeF = new System.Drawing.SizeF(144.68F, 134.46F);
            this.pbLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(608.2491F, 30.02086F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(112.7509F, 171.9583F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // txtParroquiaLugar
            // 
            this.txtParroquiaLugar.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtParroquiaLugar.LocationFloat = new DevExpress.Utils.PointFloat(149.7609F, 53.31262F);
            this.txtParroquiaLugar.Name = "txtParroquiaLugar";
            this.txtParroquiaLugar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtParroquiaLugar.SizeF = new System.Drawing.SizeF(453.0042F, 36.54172F);
            this.txtParroquiaLugar.StylePriority.UseFont = false;
            this.txtParroquiaLugar.StylePriority.UseTextAlignment = false;
            this.txtParroquiaLugar.Text = "Parroquia [Lugar]";
            this.txtParroquiaLugar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // XrLabel27
            // 
            this.XrLabel27.Font = new System.Drawing.Font("Arial", 18F);
            this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(148.5984F, 96.02095F);
            this.XrLabel27.Name = "XrLabel27";
            this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel27.SizeF = new System.Drawing.SizeF(454.1667F, 23F);
            this.XrLabel27.StylePriority.UseFont = false;
            this.XrLabel27.StylePriority.UseTextAlignment = false;
            this.XrLabel27.Text = "DIÓCESIS DE CHOLUTECA";
            this.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // txtCertificacion
            // 
            this.txtCertificacion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtCertificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.txtCertificacion.LocationFloat = new DevExpress.Utils.PointFloat(149.684F, 140.6876F);
            this.txtCertificacion.Name = "txtCertificacion";
            this.txtCertificacion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCertificacion.SizeF = new System.Drawing.SizeF(453.0811F, 35.62506F);
            this.txtCertificacion.StylePriority.UseFont = false;
            this.txtCertificacion.StylePriority.UseForeColor = false;
            this.txtCertificacion.StylePriority.UseTextAlignment = false;
            this.txtCertificacion.Text = "REPORTE D";
            this.txtCertificacion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sp_Mostrar_Todo_Sacramento_ReporteTableAdapter
            // 
            this.sp_Mostrar_Todo_Sacramento_ReporteTableAdapter.ClearBeforeFill = true;
            // 
            // dsReportes1
            // 
            this.dsReportes1.DataSetName = "DsReportes";
            this.dsReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Mostrar_Todo_Sacramento_Bautismo_ReporteTableAdapter1
            // 
            this.sp_Mostrar_Todo_Sacramento_Bautismo_ReporteTableAdapter1.ClearBeforeFill = true;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtHoy});
            this.PageFooter.HeightF = 38.54167F;
            this.PageFooter.Name = "PageFooter";
            // 
            // txtHoy
            // 
            this.txtHoy.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHoy.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.txtHoy.Name = "txtHoy";
            this.txtHoy.SerializableRtfString = resources.GetString("txtHoy.SerializableRtfString");
            this.txtHoy.SizeF = new System.Drawing.SizeF(613.3937F, 32.17908F);
            this.txtHoy.StylePriority.UseFont = false;
            // 
            // FrmReporteBautismosEdad
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter});
            this.DataAdapter = this.sp_Mostrar_Todo_Sacramento_Bautismo_ReporteTableAdapter1;
            this.DataMember = "Sp_Mostrar_Todo_Sacramento_Bautismo_Reporte";
            this.DataSource = this.dsReportes1;
            this.Margins = new System.Drawing.Printing.Margins(49, 55, 300, 100);
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox pbLogo;
        internal DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        internal DevExpress.XtraReports.UI.XRLabel txtParroquiaLugar;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel27;
        private DevExpress.XtraReports.UI.XRLabel txtCertificacion;
        private ConjuntoDatos.DsReportesTableAdapters.Sp_Mostrar_Todo_Sacramento_ReporteTableAdapter sp_Mostrar_Todo_Sacramento_ReporteTableAdapter;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        internal DevExpress.XtraReports.UI.XRLine xrLine5;
        private ConjuntoDatos.DsReportes dsReportes1;
        private ConjuntoDatos.DsReportesTableAdapters.Sp_Mostrar_Todo_Sacramento_Bautismo_ReporteTableAdapter sp_Mostrar_Todo_Sacramento_Bautismo_ReporteTableAdapter1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        internal DevExpress.XtraReports.UI.XRRichText txtHoy;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
    }
}
