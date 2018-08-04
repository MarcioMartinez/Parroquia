namespace CapaPresentacion.Formularios
{
    partial class FrmGestionFeligres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionFeligres));
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.gcDatosFeligres = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDatosFeligres = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatos = new DevExpress.XtraEditors.GroupControl();
            this.slueMadre = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.sluePadre = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumIdentidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lueSexo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaNac = new DevExpress.XtraEditors.DateEdit();
            this.meDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtApellido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroIdentidad = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnActualizarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportarPDF = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportarExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnVistaPrevia = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosFeligres)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosFeligres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).BeginInit();
            this.gcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slueMadre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePadre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaNac.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaNac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroIdentidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(268, 9);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 45);
            this.btnActualizar.TabIndex = 171;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(6, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 45);
            this.btnNuevo.TabIndex = 148;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(137, 9);
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
            this.btnCancelar.Location = new System.Drawing.Point(399, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 45);
            this.btnCancelar.TabIndex = 146;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gcDatosFeligres
            // 
            this.gcDatosFeligres.ContextMenuStrip = this.contextMenuStrip1;
            this.gcDatosFeligres.Location = new System.Drawing.Point(560, 12);
            this.gcDatosFeligres.MainView = this.gvDatosFeligres;
            this.gcDatosFeligres.Name = "gcDatosFeligres";
            this.gcDatosFeligres.Size = new System.Drawing.Size(785, 443);
            this.gcDatosFeligres.TabIndex = 0;
            this.gcDatosFeligres.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosFeligres});
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
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // gvDatosFeligres
            // 
            this.gvDatosFeligres.ColumnPanelRowHeight = 26;
            this.gvDatosFeligres.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.colTelefono,
            this.colEstado});
            this.gvDatosFeligres.GridControl = this.gcDatosFeligres;
            this.gvDatosFeligres.Name = "gvDatosFeligres";
            this.gvDatosFeligres.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvDatosFeligres.OptionsBehavior.Editable = false;
            this.gvDatosFeligres.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDatosFeligres.OptionsFind.AlwaysVisible = true;
            this.gvDatosFeligres.OptionsFind.FindNullPrompt = "Buscar aquí";
            this.gvDatosFeligres.OptionsView.ShowFooter = true;
            this.gvDatosFeligres.OptionsView.ShowGroupPanel = false;
            this.gvDatosFeligres.RowHeight = 22;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Número Identidad";
            this.gridColumn4.FieldName = "Num_Identidad";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Feligreses = {0}", "{0}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 149;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Nombre";
            this.gridColumn5.FieldName = "Nombre";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 183;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Apellido";
            this.gridColumn6.FieldName = "Apellido";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 188;
            // 
            // colTelefono
            // 
            this.colTelefono.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colTelefono.AppearanceCell.Options.UseFont = true;
            this.colTelefono.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefono.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTelefono.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colTelefono.AppearanceHeader.Options.UseFont = true;
            this.colTelefono.AppearanceHeader.Options.UseTextOptions = true;
            this.colTelefono.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefono.Caption = "Telefono";
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 3;
            this.colTelefono.Width = 89;
            // 
            // colEstado
            // 
            this.colEstado.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colEstado.AppearanceCell.Options.UseFont = true;
            this.colEstado.AppearanceCell.Options.UseTextOptions = true;
            this.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colEstado.AppearanceHeader.Options.UseFont = true;
            this.colEstado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 82;
            // 
            // gcDatos
            // 
            this.gcDatos.Controls.Add(this.slueMadre);
            this.gcDatos.Controls.Add(this.labelControl10);
            this.gcDatos.Controls.Add(this.sluePadre);
            this.gcDatos.Controls.Add(this.labelControl9);
            this.gcDatos.Controls.Add(this.lueSexo);
            this.gcDatos.Controls.Add(this.labelControl6);
            this.gcDatos.Controls.Add(this.labelControl7);
            this.gcDatos.Controls.Add(this.txtCorreo);
            this.gcDatos.Controls.Add(this.labelControl8);
            this.gcDatos.Controls.Add(this.txtTelefono);
            this.gcDatos.Controls.Add(this.labelControl5);
            this.gcDatos.Controls.Add(this.deFechaNac);
            this.gcDatos.Controls.Add(this.meDireccion);
            this.gcDatos.Controls.Add(this.labelControl4);
            this.gcDatos.Controls.Add(this.labelControl3);
            this.gcDatos.Controls.Add(this.txtApellido);
            this.gcDatos.Controls.Add(this.labelControl2);
            this.gcDatos.Controls.Add(this.txtNombre);
            this.gcDatos.Controls.Add(this.labelControl1);
            this.gcDatos.Controls.Add(this.txtNumeroIdentidad);
            this.gcDatos.Enabled = false;
            this.gcDatos.Location = new System.Drawing.Point(13, 12);
            this.gcDatos.Name = "gcDatos";
            this.gcDatos.Size = new System.Drawing.Size(530, 443);
            this.gcDatos.TabIndex = 149;
            this.gcDatos.Text = "Datos del Feligres";
            // 
            // slueMadre
            // 
            this.slueMadre.EditValue = "";
            this.slueMadre.Location = new System.Drawing.Point(168, 395);
            this.slueMadre.Name = "slueMadre";
            this.slueMadre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.slueMadre.Properties.Appearance.Options.UseFont = true;
            this.slueMadre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueMadre.Properties.DisplayMember = "NombreCompleto";
            this.slueMadre.Properties.NullText = "Seleccione la madre";
            this.slueMadre.Properties.PopupFormSize = new System.Drawing.Size(500, 300);
            this.slueMadre.Properties.ValueMember = "Num_Identidad";
            this.slueMadre.Properties.View = this.gridView1;
            this.slueMadre.Size = new System.Drawing.Size(235, 28);
            this.slueMadre.TabIndex = 190;
            this.slueMadre.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.slueMadre_CustomDisplayText);
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 26;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.DetailHeight = 100;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Buscar aquí";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 22;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Número Identidad";
            this.gridColumn1.FieldName = "Num_Identidad";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Padres = {0}", "{0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Apellido";
            this.gridColumn3.FieldName = "Apellido";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(118, 398);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 21);
            this.labelControl10.TabIndex = 189;
            this.labelControl10.Text = "Madre";
            // 
            // sluePadre
            // 
            this.sluePadre.EditValue = "";
            this.sluePadre.Location = new System.Drawing.Point(168, 358);
            this.sluePadre.Name = "sluePadre";
            this.sluePadre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.sluePadre.Properties.Appearance.Options.UseFont = true;
            this.sluePadre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluePadre.Properties.DisplayMember = "NombreCompleto";
            this.sluePadre.Properties.NullText = "Seleccione el padre";
            this.sluePadre.Properties.PopupFormSize = new System.Drawing.Size(500, 300);
            this.sluePadre.Properties.ValueMember = "Num_Identidad";
            this.sluePadre.Properties.View = this.searchLookUpEdit1View;
            this.sluePadre.Size = new System.Drawing.Size(235, 28);
            this.sluePadre.TabIndex = 188;
            this.sluePadre.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.sluePadre_CustomDisplayText_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.ColumnPanelRowHeight = 26;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumIdentidad,
            this.colNombre,
            this.colApellido});
            this.searchLookUpEdit1View.DetailHeight = 100;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsBehavior.AllowIncrementalSearch = true;
            this.searchLookUpEdit1View.OptionsBehavior.Editable = false;
            this.searchLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.searchLookUpEdit1View.OptionsFind.FindNullPrompt = "Buscar aquí";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowFooter = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.RowHeight = 22;
            // 
            // colNumIdentidad
            // 
            this.colNumIdentidad.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colNumIdentidad.AppearanceCell.Options.UseFont = true;
            this.colNumIdentidad.AppearanceCell.Options.UseTextOptions = true;
            this.colNumIdentidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumIdentidad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colNumIdentidad.AppearanceHeader.Options.UseFont = true;
            this.colNumIdentidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumIdentidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumIdentidad.Caption = "Número Identidad";
            this.colNumIdentidad.FieldName = "Num_Identidad";
            this.colNumIdentidad.Name = "colNumIdentidad";
            this.colNumIdentidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Padres = {0}", "{0}")});
            this.colNumIdentidad.Visible = true;
            this.colNumIdentidad.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colNombre.AppearanceCell.Options.UseFont = true;
            this.colNombre.AppearanceCell.Options.UseTextOptions = true;
            this.colNombre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombre.AppearanceHeader.Options.UseFont = true;
            this.colNombre.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colApellido
            // 
            this.colApellido.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colApellido.AppearanceCell.Options.UseFont = true;
            this.colApellido.AppearanceCell.Options.UseTextOptions = true;
            this.colApellido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colApellido.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colApellido.AppearanceHeader.Options.UseFont = true;
            this.colApellido.AppearanceHeader.Options.UseTextOptions = true;
            this.colApellido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApellido.Caption = "Apellido";
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(122, 361);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 21);
            this.labelControl9.TabIndex = 187;
            this.labelControl9.Text = "Padre";
            // 
            // lueSexo
            // 
            this.lueSexo.Location = new System.Drawing.Point(168, 321);
            this.lueSexo.Name = "lueSexo";
            this.lueSexo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.lueSexo.Properties.Appearance.Options.UseFont = true;
            this.lueSexo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSexo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Sexo", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sexo", "Sexo")});
            this.lueSexo.Properties.DisplayMember = "Sexo";
            this.lueSexo.Properties.NullText = "Seleccione el sexo";
            this.lueSexo.Properties.ValueMember = "Id_Sexo";
            this.lueSexo.Size = new System.Drawing.Size(236, 28);
            this.lueSexo.TabIndex = 186;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(129, 324);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 21);
            this.labelControl6.TabIndex = 185;
            this.labelControl6.Text = "Sexo";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(113, 250);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 21);
            this.labelControl7.TabIndex = 184;
            this.labelControl7.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.EditValue = "";
            this.txtCorreo.Location = new System.Drawing.Point(168, 247);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Properties.Appearance.Options.UseFont = true;
            this.txtCorreo.Properties.Mask.EditMask = "(\\w|[\\.\\-])+@(\\w|[\\-]+\\.)*(\\w|[\\-]){2,63}\\.[a-zA-Z]{2,4}";
            this.txtCorreo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCorreo.Size = new System.Drawing.Size(344, 28);
            this.txtCorreo.TabIndex = 183;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(98, 210);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 21);
            this.labelControl8.TabIndex = 182;
            this.labelControl8.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(168, 211);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.Mask.EditMask = "0000-0000";
            this.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefono.Size = new System.Drawing.Size(160, 28);
            this.txtTelefono.TabIndex = 181;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 287);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(155, 21);
            this.labelControl5.TabIndex = 180;
            this.labelControl5.Text = "Fecha de Nacimiento";
            // 
            // deFechaNac
            // 
            this.deFechaNac.EditValue = null;
            this.deFechaNac.Location = new System.Drawing.Point(168, 284);
            this.deFechaNac.Name = "deFechaNac";
            this.deFechaNac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.deFechaNac.Properties.Appearance.Options.UseFont = true;
            this.deFechaNac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaNac.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaNac.Size = new System.Drawing.Size(205, 28);
            this.deFechaNac.TabIndex = 179;
            // 
            // meDireccion
            // 
            this.meDireccion.Location = new System.Drawing.Point(168, 150);
            this.meDireccion.Name = "meDireccion";
            this.meDireccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meDireccion.Properties.Appearance.Options.UseFont = true;
            this.meDireccion.Size = new System.Drawing.Size(344, 53);
            this.meDireccion.TabIndex = 178;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(93, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 21);
            this.labelControl4.TabIndex = 177;
            this.labelControl4.Text = "Dirección";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(97, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 21);
            this.labelControl3.TabIndex = 176;
            this.labelControl3.Text = "Apellidos";
            // 
            // txtApellido
            // 
            this.txtApellido.EditValue = "";
            this.txtApellido.Location = new System.Drawing.Point(168, 113);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Properties.Appearance.Options.UseFont = true;
            this.txtApellido.Size = new System.Drawing.Size(344, 28);
            this.txtApellido.TabIndex = 175;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(106, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 21);
            this.labelControl2.TabIndex = 174;
            this.labelControl2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.Location = new System.Drawing.Point(168, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(345, 28);
            this.txtNombre.TabIndex = 173;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 21);
            this.labelControl1.TabIndex = 172;
            this.labelControl1.Text = "Número de Identidad";
            // 
            // txtNumeroIdentidad
            // 
            this.txtNumeroIdentidad.Location = new System.Drawing.Point(170, 40);
            this.txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            this.txtNumeroIdentidad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIdentidad.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroIdentidad.Properties.Mask.EditMask = "0000-0000-00000";
            this.txtNumeroIdentidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtNumeroIdentidad.Size = new System.Drawing.Size(181, 28);
            this.txtNumeroIdentidad.TabIndex = 171;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnActualizarDatos);
            this.panelControl1.Controls.Add(this.btnExportarPDF);
            this.panelControl1.Controls.Add(this.btnExportarExcel);
            this.panelControl1.Controls.Add(this.btnVistaPrevia);
            this.panelControl1.Location = new System.Drawing.Point(560, 461);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(785, 64);
            this.panelControl1.TabIndex = 172;
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarDatos.ImageOptions.Image")));
            this.btnActualizarDatos.Location = new System.Drawing.Point(51, 10);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(165, 45);
            this.btnActualizarDatos.TabIndex = 151;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.ImageOptions.Image")));
            this.btnExportarPDF.Location = new System.Drawing.Point(224, 10);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(165, 45);
            this.btnExportarPDF.TabIndex = 150;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.ImageOptions.Image")));
            this.btnExportarExcel.Location = new System.Drawing.Point(398, 10);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(165, 45);
            this.btnExportarExcel.TabIndex = 149;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVistaPrevia.ImageOptions.Image")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(570, 10);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(165, 45);
            this.btnVistaPrevia.TabIndex = 148;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnNuevo);
            this.panelControl2.Controls.Add(this.btnGuardar);
            this.panelControl2.Controls.Add(this.btnCancelar);
            this.panelControl2.Controls.Add(this.btnActualizar);
            this.panelControl2.Location = new System.Drawing.Point(13, 461);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(530, 64);
            this.panelControl2.TabIndex = 173;
            // 
            // FrmGestionFeligres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 535);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcDatos);
            this.Controls.Add(this.gcDatosFeligres);
            this.Name = "FrmGestionFeligres";
            this.Text = "Gestión Feligres";
            this.Load += new System.EventHandler(this.FrmGestionFeligres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosFeligres)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosFeligres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).EndInit();
            this.gcDatos.ResumeLayout(false);
            this.gcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slueMadre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePadre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaNac.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaNac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroIdentidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal DevExpress.XtraEditors.SimpleButton btnNuevo;
        internal DevExpress.XtraEditors.SimpleButton btnGuardar;
        internal DevExpress.XtraEditors.SimpleButton btnCancelar;
        internal DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraGrid.GridControl gcDatosFeligres;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatosFeligres;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.GroupControl gcDatos;
        private DevExpress.XtraEditors.SearchLookUpEdit slueMadre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SearchLookUpEdit sluePadre;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colNumIdentidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lueSexo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deFechaNac;
        private DevExpress.XtraEditors.MemoEdit meDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtApellido;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNumeroIdentidad;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnActualizarDatos;
        internal DevExpress.XtraEditors.SimpleButton btnExportarPDF;
        internal DevExpress.XtraEditors.SimpleButton btnExportarExcel;
        internal DevExpress.XtraEditors.SimpleButton btnVistaPrevia;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}