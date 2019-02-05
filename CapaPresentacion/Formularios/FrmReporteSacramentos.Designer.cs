namespace CapaPresentacion.Formularios
{
    partial class FrmReporteSacramentos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteSacramentos));
            this.cboAnios = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboMeses = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnVistaPrevia = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboAnios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMeses.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnios
            // 
            this.cboAnios.Location = new System.Drawing.Point(8, 12);
            this.cboAnios.Name = "cboAnios";
            this.cboAnios.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.cboAnios.Properties.Appearance.Options.UseFont = true;
            this.cboAnios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAnios.Properties.NullText = "AÑO";
            this.cboAnios.Size = new System.Drawing.Size(134, 28);
            this.cboAnios.TabIndex = 0;
            this.cboAnios.SelectedIndexChanged += new System.EventHandler(this.cboAnios_SelectedIndexChanged);
            // 
            // cboMeses
            // 
            this.cboMeses.Location = new System.Drawing.Point(152, 12);
            this.cboMeses.Name = "cboMeses";
            this.cboMeses.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.cboMeses.Properties.Appearance.Options.UseFont = true;
            this.cboMeses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMeses.Properties.NullText = "MES";
            this.cboMeses.Size = new System.Drawing.Size(134, 28);
            this.cboMeses.TabIndex = 1;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVistaPrevia.ImageOptions.Image")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(8, 46);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(274, 45);
            this.btnVistaPrevia.TabIndex = 149;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // FrmReporteSacramentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 101);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.cboMeses);
            this.Controls.Add(this.cboAnios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteSacramentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione Fecha";
            this.Load += new System.EventHandler(this.FrmReporteSacramentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboAnios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMeses.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboAnios;
        private DevExpress.XtraEditors.ComboBoxEdit cboMeses;
        internal DevExpress.XtraEditors.SimpleButton btnVistaPrevia;
    }
}