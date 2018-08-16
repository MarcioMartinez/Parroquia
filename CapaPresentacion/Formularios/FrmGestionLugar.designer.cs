namespace CapaPresentacion
{
    partial class FrmGestionLugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionLugar));
            this.gcDatosLugar = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDatosLugar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLugar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLugar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.gcDatos = new DevExpress.XtraEditors.GroupControl();
            this.txtIdLugar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLugar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosLugar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosLugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).BeginInit();
            this.gcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLugar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDatosLugar
            // 
            this.gcDatosLugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcDatosLugar.ContextMenuStrip = this.contextMenuStrip1;
            this.gcDatosLugar.Location = new System.Drawing.Point(426, 16);
            this.gcDatosLugar.MainView = this.gvDatosLugar;
            this.gcDatosLugar.Name = "gcDatosLugar";
            this.gcDatosLugar.Size = new System.Drawing.Size(352, 202);
            this.gcDatosLugar.TabIndex = 182;
            this.gcDatosLugar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosLugar});
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
            // gvDatosLugar
            // 
            this.gvDatosLugar.ColumnPanelRowHeight = 26;
            this.gvDatosLugar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLugar,
            this.colLugar});
            this.gvDatosLugar.GridControl = this.gcDatosLugar;
            this.gvDatosLugar.Name = "gvDatosLugar";
            this.gvDatosLugar.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvDatosLugar.OptionsBehavior.Editable = false;
            this.gvDatosLugar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDatosLugar.OptionsFind.AlwaysVisible = true;
            this.gvDatosLugar.OptionsFind.FindNullPrompt = "Buscar aquí";
            this.gvDatosLugar.OptionsView.ShowFooter = true;
            this.gvDatosLugar.OptionsView.ShowGroupPanel = false;
            this.gvDatosLugar.RowHeight = 22;
            // 
            // colIdLugar
            // 
            this.colIdLugar.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colIdLugar.AppearanceCell.Options.UseFont = true;
            this.colIdLugar.AppearanceCell.Options.UseTextOptions = true;
            this.colIdLugar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdLugar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIdLugar.AppearanceHeader.Options.UseFont = true;
            this.colIdLugar.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdLugar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdLugar.Caption = "Id Lugar";
            this.colIdLugar.FieldName = "Id_Lugar";
            this.colIdLugar.Name = "colIdLugar";
            // 
            // colLugar
            // 
            this.colLugar.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colLugar.AppearanceCell.Options.UseFont = true;
            this.colLugar.AppearanceCell.Options.UseTextOptions = true;
            this.colLugar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLugar.AppearanceHeader.Options.UseFont = true;
            this.colLugar.AppearanceHeader.Options.UseTextOptions = true;
            this.colLugar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLugar.Caption = "Lugar";
            this.colLugar.FieldName = "Lugar";
            this.colLugar.Name = "colLugar";
            this.colLugar.Visible = true;
            this.colLugar.VisibleIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 173);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 45);
            this.btnNuevo.TabIndex = 180;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(110, 173);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 45);
            this.btnGuardar.TabIndex = 179;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(321, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 45);
            this.btnCancelar.TabIndex = 178;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(214, 173);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 45);
            this.btnActualizar.TabIndex = 181;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gcDatos
            // 
            this.gcDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcDatos.Controls.Add(this.txtIdLugar);
            this.gcDatos.Controls.Add(this.labelControl2);
            this.gcDatos.Controls.Add(this.txtLugar);
            this.gcDatos.Enabled = false;
            this.gcDatos.Location = new System.Drawing.Point(12, 16);
            this.gcDatos.Name = "gcDatos";
            this.gcDatos.Size = new System.Drawing.Size(408, 151);
            this.gcDatos.TabIndex = 177;
            this.gcDatos.Text = "Datos del Lugar";
            // 
            // txtIdLugar
            // 
            this.txtIdLugar.EditValue = "";
            this.txtIdLugar.Location = new System.Drawing.Point(98, 25);
            this.txtIdLugar.Name = "txtIdLugar";
            this.txtIdLugar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdLugar.Properties.Appearance.Options.UseFont = true;
            this.txtIdLugar.Size = new System.Drawing.Size(57, 28);
            this.txtIdLugar.TabIndex = 175;
            this.txtIdLugar.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 21);
            this.labelControl2.TabIndex = 174;
            this.labelControl2.Text = "Lugar";
            // 
            // txtLugar
            // 
            this.txtLugar.EditValue = "";
            this.txtLugar.Location = new System.Drawing.Point(98, 59);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Properties.Appearance.Options.UseFont = true;
            this.txtLugar.Size = new System.Drawing.Size(277, 28);
            this.txtLugar.TabIndex = 173;
            // 
            // FrmGestionLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 234);
            this.Controls.Add(this.gcDatosLugar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gcDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGestionLugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Lugar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionLugar_FormClosing);
            this.Load += new System.EventHandler(this.FrmGestionLugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosLugar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosLugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).EndInit();
            this.gcDatos.ResumeLayout(false);
            this.gcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLugar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDatosLugar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatosLugar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLugar;
        private DevExpress.XtraGrid.Columns.GridColumn colLugar;
        internal DevExpress.XtraEditors.SimpleButton btnNuevo;
        internal DevExpress.XtraEditors.SimpleButton btnGuardar;
        internal DevExpress.XtraEditors.SimpleButton btnCancelar;
        internal DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.GroupControl gcDatos;
        private DevExpress.XtraEditors.TextEdit txtIdLugar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLugar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}