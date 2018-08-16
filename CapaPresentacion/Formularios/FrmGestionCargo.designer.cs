namespace CapaPresentacion.Formularios
{
    partial class FrmGestionCargo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionCargo));
            this.gcDatos = new DevExpress.XtraEditors.GroupControl();
            this.txtIdCargo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCargo = new DevExpress.XtraEditors.TextEdit();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.gcDatosCargos = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDatosCargo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).BeginInit();
            this.gcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosCargos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDatos
            // 
            this.gcDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcDatos.Controls.Add(this.txtIdCargo);
            this.gcDatos.Controls.Add(this.labelControl2);
            this.gcDatos.Controls.Add(this.txtCargo);
            this.gcDatos.Enabled = false;
            this.gcDatos.Location = new System.Drawing.Point(6, 12);
            this.gcDatos.Name = "gcDatos";
            this.gcDatos.Size = new System.Drawing.Size(426, 151);
            this.gcDatos.TabIndex = 150;
            this.gcDatos.Text = "Datos del Cargo";
            // 
            // txtIdCargo
            // 
            this.txtIdCargo.EditValue = "";
            this.txtIdCargo.Location = new System.Drawing.Point(98, 30);
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCargo.Properties.Appearance.Options.UseFont = true;
            this.txtIdCargo.Size = new System.Drawing.Size(57, 28);
            this.txtIdCargo.TabIndex = 175;
            this.txtIdCargo.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 21);
            this.labelControl2.TabIndex = 174;
            this.labelControl2.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.EditValue = "";
            this.txtCargo.Location = new System.Drawing.Point(98, 64);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Properties.Appearance.Options.UseFont = true;
            this.txtCargo.Size = new System.Drawing.Size(277, 28);
            this.txtCargo.TabIndex = 173;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(10, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 45);
            this.btnNuevo.TabIndex = 174;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(108, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 45);
            this.btnGuardar.TabIndex = 173;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(319, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 45);
            this.btnCancelar.TabIndex = 172;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(212, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 45);
            this.btnActualizar.TabIndex = 175;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gcDatosCargos
            // 
            this.gcDatosCargos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcDatosCargos.ContextMenuStrip = this.contextMenuStrip1;
            this.gcDatosCargos.Location = new System.Drawing.Point(438, 12);
            this.gcDatosCargos.MainView = this.gvDatosCargo;
            this.gcDatosCargos.Name = "gcDatosCargos";
            this.gcDatosCargos.Size = new System.Drawing.Size(364, 216);
            this.gcDatosCargos.TabIndex = 176;
            this.gcDatosCargos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosCargo});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Edit_48px;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Cancel_48px;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // gvDatosCargo
            // 
            this.gvDatosCargo.ColumnPanelRowHeight = 26;
            this.gvDatosCargo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCargo,
            this.colCargo});
            this.gvDatosCargo.GridControl = this.gcDatosCargos;
            this.gvDatosCargo.Name = "gvDatosCargo";
            this.gvDatosCargo.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvDatosCargo.OptionsBehavior.Editable = false;
            this.gvDatosCargo.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDatosCargo.OptionsFind.AlwaysVisible = true;
            this.gvDatosCargo.OptionsFind.FindNullPrompt = "Buscar aquí";
            this.gvDatosCargo.OptionsView.ShowFooter = true;
            this.gvDatosCargo.OptionsView.ShowGroupPanel = false;
            this.gvDatosCargo.RowHeight = 22;
            // 
            // colIdCargo
            // 
            this.colIdCargo.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colIdCargo.AppearanceCell.Options.UseFont = true;
            this.colIdCargo.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCargo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCargo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIdCargo.AppearanceHeader.Options.UseFont = true;
            this.colIdCargo.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCargo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdCargo.Caption = "Id Cargo";
            this.colIdCargo.FieldName = "Id_Cargo";
            this.colIdCargo.Name = "colIdCargo";
            // 
            // colCargo
            // 
            this.colCargo.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colCargo.AppearanceCell.Options.UseFont = true;
            this.colCargo.AppearanceCell.Options.UseTextOptions = true;
            this.colCargo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCargo.AppearanceHeader.Options.UseFont = true;
            this.colCargo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCargo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCargo.Caption = "Cargo";
            this.colCargo.FieldName = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGuardar);
            this.panelControl1.Controls.Add(this.btnNuevo);
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Controls.Add(this.btnActualizar);
            this.panelControl1.Location = new System.Drawing.Point(6, 169);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(426, 59);
            this.panelControl1.TabIndex = 177;
            // 
            // FrmGestionCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 234);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcDatosCargos);
            this.Controls.Add(this.gcDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGestionCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Cargo";
            this.Load += new System.EventHandler(this.FrmGestionCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).EndInit();
            this.gcDatos.ResumeLayout(false);
            this.gcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosCargos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDatos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCargo;
        internal DevExpress.XtraEditors.SimpleButton btnNuevo;
        internal DevExpress.XtraEditors.SimpleButton btnGuardar;
        internal DevExpress.XtraEditors.SimpleButton btnCancelar;
        internal DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.TextEdit txtIdCargo;
        private DevExpress.XtraGrid.GridControl gcDatosCargos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatosCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}