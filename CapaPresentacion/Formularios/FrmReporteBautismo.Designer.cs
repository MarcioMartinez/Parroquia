namespace CapaPresentacion.Formularios
{
    partial class FrmReporteBautismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteBautismo));
            this.btnVistaPrevia = new DevExpress.XtraEditors.SimpleButton();
            this.cboAnios = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAnios.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVistaPrevia.ImageOptions.Image")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(12, 41);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(235, 45);
            this.btnVistaPrevia.TabIndex = 151;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cboAnios
            // 
            this.cboAnios.Location = new System.Drawing.Point(12, 7);
            this.cboAnios.Name = "cboAnios";
            this.cboAnios.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.cboAnios.Properties.Appearance.Options.UseFont = true;
            this.cboAnios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAnios.Properties.NullText = "SELECCIONE";
            this.cboAnios.Size = new System.Drawing.Size(235, 28);
            this.cboAnios.TabIndex = 150;
            // 
            // FrmReporteBautismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 95);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.cboAnios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteBautismo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione Rango";
            this.Load += new System.EventHandler(this.FrmReporteBautismo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboAnios.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnVistaPrevia;
        private DevExpress.XtraEditors.ComboBoxEdit cboAnios;
    }
}