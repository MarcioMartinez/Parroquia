namespace CapaPresentacion.Formularios
{
    partial class FrmDatosGenerales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosGenerales));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.gcDatos = new DevExpress.XtraEditors.GroupControl();
            this.cEUsarLogo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnQuitar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.pELogo = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.meDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtIdDato = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).BeginInit();
            this.gcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEUsarLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdDato.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnGuardar);
            this.panelControl2.Controls.Add(this.btnCancelar);
            this.panelControl2.Location = new System.Drawing.Point(15, 487);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(584, 64);
            this.panelControl2.TabIndex = 177;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(169, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 45);
            this.btnGuardar.TabIndex = 147;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(300, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 45);
            this.btnCancelar.TabIndex = 146;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gcDatos
            // 
            this.gcDatos.Controls.Add(this.cEUsarLogo);
            this.gcDatos.Controls.Add(this.labelControl3);
            this.gcDatos.Controls.Add(this.btnQuitar);
            this.gcDatos.Controls.Add(this.btnAgregar);
            this.gcDatos.Controls.Add(this.pELogo);
            this.gcDatos.Controls.Add(this.labelControl1);
            this.gcDatos.Controls.Add(this.labelControl8);
            this.gcDatos.Controls.Add(this.txtTelefono);
            this.gcDatos.Controls.Add(this.meDireccion);
            this.gcDatos.Controls.Add(this.labelControl4);
            this.gcDatos.Controls.Add(this.labelControl2);
            this.gcDatos.Controls.Add(this.txtNombre);
            this.gcDatos.Controls.Add(this.txtIdDato);
            this.gcDatos.Enabled = false;
            this.gcDatos.Location = new System.Drawing.Point(15, 11);
            this.gcDatos.Name = "gcDatos";
            this.gcDatos.Size = new System.Drawing.Size(584, 470);
            this.gcDatos.TabIndex = 176;
            this.gcDatos.Text = "Datos de la parroquia";
            // 
            // cEUsarLogo
            // 
            this.cEUsarLogo.Location = new System.Drawing.Point(197, 432);
            this.cEUsarLogo.Name = "cEUsarLogo";
            this.cEUsarLogo.Properties.Caption = "Si";
            this.cEUsarLogo.Size = new System.Drawing.Size(75, 19);
            this.cEUsarLogo.TabIndex = 223;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 429);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(160, 21);
            this.labelControl3.TabIndex = 222;
            this.labelControl3.Text = "Usar logo en reportes";
            // 
            // btnQuitar
            // 
            this.btnQuitar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnQuitar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.ImageOptions.Image")));
            this.btnQuitar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnQuitar.Location = new System.Drawing.Point(545, 216);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(27, 23);
            this.btnQuitar.TabIndex = 221;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAgregar.Location = new System.Drawing.Point(545, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(27, 23);
            this.btnAgregar.TabIndex = 220;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pELogo
            // 
            this.pELogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pELogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pELogo.EditValue = global::CapaPresentacion.Properties.Resources.general;
            this.pELogo.Location = new System.Drawing.Point(197, 187);
            this.pELogo.Name = "pELogo";
            this.pELogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pELogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pELogo.Properties.ZoomAccelerationFactor = 1D;
            this.pELogo.Size = new System.Drawing.Size(343, 226);
            this.pELogo.TabIndex = 219;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(155, 187);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 21);
            this.labelControl1.TabIndex = 218;
            this.labelControl1.Text = "Logo";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(126, 146);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 21);
            this.labelControl8.TabIndex = 217;
            this.labelControl8.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(196, 144);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.Mask.EditMask = "0000-0000";
            this.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefono.Size = new System.Drawing.Size(160, 28);
            this.txtTelefono.TabIndex = 216;
            // 
            // meDireccion
            // 
            this.meDireccion.Location = new System.Drawing.Point(196, 89);
            this.meDireccion.Name = "meDireccion";
            this.meDireccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meDireccion.Properties.Appearance.Options.UseFont = true;
            this.meDireccion.Size = new System.Drawing.Size(344, 49);
            this.meDireccion.TabIndex = 215;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(121, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 21);
            this.labelControl4.TabIndex = 214;
            this.labelControl4.Text = "Dirección";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(174, 21);
            this.labelControl2.TabIndex = 213;
            this.labelControl2.Text = "Nombre de la parroquia";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.Location = new System.Drawing.Point(195, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(345, 28);
            this.txtNombre.TabIndex = 212;
            // 
            // txtIdDato
            // 
            this.txtIdDato.EditValue = "";
            this.txtIdDato.Location = new System.Drawing.Point(68, 23);
            this.txtIdDato.Name = "txtIdDato";
            this.txtIdDato.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDato.Properties.Appearance.Options.UseFont = true;
            this.txtIdDato.Size = new System.Drawing.Size(58, 28);
            this.txtIdDato.TabIndex = 211;
            this.txtIdDato.Visible = false;
            // 
            // FrmDatosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 563);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDatosGenerales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos generales";
            this.Load += new System.EventHandler(this.FrmDatosGenerales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).EndInit();
            this.gcDatos.ResumeLayout(false);
            this.gcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEUsarLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdDato.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        internal DevExpress.XtraEditors.SimpleButton btnGuardar;
        internal DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.GroupControl gcDatos;
        private DevExpress.XtraEditors.SimpleButton btnQuitar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.PictureEdit pELogo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.MemoEdit meDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtIdDato;
        private DevExpress.XtraEditors.CheckEdit cEUsarLogo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}