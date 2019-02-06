namespace CapaPresentacion.Formularios
{
    partial class FrmGestionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionUsuario));
            this.gcDatos = new DevExpress.XtraEditors.GroupControl();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.slueEmpleado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumIdentidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdUsuario = new DevExpress.XtraEditors.TextEdit();
            this.gcDatosUsuario = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDatosUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContrasena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).BeginInit();
            this.gcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosUsuario)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDatos
            // 
            this.gcDatos.Controls.Add(this.chkEstado);
            this.gcDatos.Controls.Add(this.slueEmpleado);
            this.gcDatos.Controls.Add(this.labelControl9);
            this.gcDatos.Controls.Add(this.labelControl3);
            this.gcDatos.Controls.Add(this.txtContrasena);
            this.gcDatos.Controls.Add(this.labelControl2);
            this.gcDatos.Controls.Add(this.txtUsuario);
            this.gcDatos.Controls.Add(this.labelControl1);
            this.gcDatos.Controls.Add(this.txtIdUsuario);
            this.gcDatos.Enabled = false;
            this.gcDatos.Location = new System.Drawing.Point(12, 12);
            this.gcDatos.Name = "gcDatos";
            this.gcDatos.Size = new System.Drawing.Size(530, 443);
            this.gcDatos.TabIndex = 150;
            this.gcDatos.Text = "Datos del Usuario";
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(84, 144);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Properties.Appearance.Options.UseFont = true;
            this.chkEstado.Properties.Caption = "Estado";
            this.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkEstado.Size = new System.Drawing.Size(111, 23);
            this.chkEstado.TabIndex = 192;
            // 
            // slueEmpleado
            // 
            this.slueEmpleado.EditValue = "Seleccione ";
            this.slueEmpleado.Location = new System.Drawing.Point(137, 110);
            this.slueEmpleado.Name = "slueEmpleado";
            this.slueEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.slueEmpleado.Properties.Appearance.Options.UseFont = true;
            this.slueEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueEmpleado.Properties.DisplayMember = "NombreCompleto";
            this.slueEmpleado.Properties.NullText = "Seleccione el Empleado";
            this.slueEmpleado.Properties.PopupFormSize = new System.Drawing.Size(500, 300);
            this.slueEmpleado.Properties.ValueMember = "Num_Identidad";
            this.slueEmpleado.Properties.View = this.searchLookUpEdit1View;
            this.slueEmpleado.Size = new System.Drawing.Size(235, 28);
            this.slueEmpleado.TabIndex = 188;
            this.slueEmpleado.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.slueEmpleado_CustomDisplayText);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.ColumnPanelRowHeight = 26;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumIdentidad,
            this.colNombreCompleto});
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Empleado = {0}", "{0}")});
            this.colNumIdentidad.Visible = true;
            this.colNumIdentidad.VisibleIndex = 0;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colNombreCompleto.AppearanceCell.Options.UseFont = true;
            this.colNombreCompleto.AppearanceCell.Options.UseTextOptions = true;
            this.colNombreCompleto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNombreCompleto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombreCompleto.AppearanceHeader.Options.UseFont = true;
            this.colNombreCompleto.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombreCompleto.Caption = "Nombre Completo";
            this.colNombreCompleto.FieldName = "NombreCompleto";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.Visible = true;
            this.colNombreCompleto.VisibleIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(60, 113);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 21);
            this.labelControl9.TabIndex = 187;
            this.labelControl9.Text = "Empleado";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(75, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 21);
            this.labelControl3.TabIndex = 176;
            this.labelControl3.Text = "Usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.EditValue = "";
            this.txtContrasena.Location = new System.Drawing.Point(137, 76);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Properties.Appearance.Options.UseFont = true;
            this.txtContrasena.Properties.UseSystemPasswordChar = true;
            this.txtContrasena.Size = new System.Drawing.Size(344, 28);
            this.txtContrasena.TabIndex = 175;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 21);
            this.labelControl2.TabIndex = 174;
            this.labelControl2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(137, 40);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Size = new System.Drawing.Size(345, 28);
            this.txtUsuario.TabIndex = 173;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 21);
            this.labelControl1.TabIndex = 172;
            this.labelControl1.Text = "Id Usuario";
            this.labelControl1.Visible = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(137, 187);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(181, 28);
            this.txtIdUsuario.TabIndex = 171;
            this.txtIdUsuario.Visible = false;
            // 
            // gcDatosUsuario
            // 
            this.gcDatosUsuario.ContextMenuStrip = this.contextMenuStrip1;
            this.gcDatosUsuario.Location = new System.Drawing.Point(560, 12);
            this.gcDatosUsuario.MainView = this.gvDatosUsuario;
            this.gcDatosUsuario.Name = "gcDatosUsuario";
            this.gcDatosUsuario.Size = new System.Drawing.Size(785, 443);
            this.gcDatosUsuario.TabIndex = 151;
            this.gcDatosUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosUsuario});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Edit_48px;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // gvDatosUsuario
            // 
            this.gvDatosUsuario.ColumnPanelRowHeight = 26;
            this.gvDatosUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colUsuario,
            this.colContrasena,
            this.colEmpleado,
            this.colEstado});
            this.gvDatosUsuario.GridControl = this.gcDatosUsuario;
            this.gvDatosUsuario.Name = "gvDatosUsuario";
            this.gvDatosUsuario.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvDatosUsuario.OptionsBehavior.Editable = false;
            this.gvDatosUsuario.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDatosUsuario.OptionsFind.AlwaysVisible = true;
            this.gvDatosUsuario.OptionsFind.FindNullPrompt = "Buscar aquí";
            this.gvDatosUsuario.OptionsView.ShowFooter = true;
            this.gvDatosUsuario.OptionsView.ShowGroupPanel = false;
            this.gvDatosUsuario.RowHeight = 22;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colIdUsuario.AppearanceCell.Options.UseFont = true;
            this.colIdUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colIdUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUsuario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colIdUsuario.AppearanceHeader.Options.UseFont = true;
            this.colIdUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdUsuario.Caption = "Id Usuario";
            this.colIdUsuario.FieldName = "Id_Usuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Usuario = {0}", "{0}")});
            this.colIdUsuario.Width = 149;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colUsuario.AppearanceCell.Options.UseFont = true;
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colUsuario.AppearanceHeader.Options.UseFont = true;
            this.colUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsuario.Caption = "Usuario";
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 0;
            this.colUsuario.Width = 205;
            // 
            // colContrasena
            // 
            this.colContrasena.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colContrasena.AppearanceCell.Options.UseFont = true;
            this.colContrasena.AppearanceCell.Options.UseTextOptions = true;
            this.colContrasena.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colContrasena.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colContrasena.AppearanceHeader.Options.UseFont = true;
            this.colContrasena.AppearanceHeader.Options.UseTextOptions = true;
            this.colContrasena.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContrasena.Caption = "Contraseña";
            this.colContrasena.FieldName = "Contraseña";
            this.colContrasena.Name = "colContrasena";
            this.colContrasena.Width = 188;
            // 
            // colEmpleado
            // 
            this.colEmpleado.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colEmpleado.AppearanceCell.Options.UseFont = true;
            this.colEmpleado.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEmpleado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colEmpleado.AppearanceHeader.Options.UseFont = true;
            this.colEmpleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpleado.Caption = "Empleado";
            this.colEmpleado.FieldName = "NombreCompleto";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.Visible = true;
            this.colEmpleado.VisibleIndex = 1;
            this.colEmpleado.Width = 272;
            // 
            // colEstado
            // 
            this.colEstado.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colEstado.AppearanceCell.Options.UseFont = true;
            this.colEstado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colEstado.AppearanceHeader.Options.UseFont = true;
            this.colEstado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 214;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnNuevo);
            this.panelControl2.Controls.Add(this.btnGuardar);
            this.panelControl2.Controls.Add(this.btnCancelar);
            this.panelControl2.Controls.Add(this.btnActualizar);
            this.panelControl2.Location = new System.Drawing.Point(12, 461);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(530, 64);
            this.panelControl2.TabIndex = 174;
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
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarDatos.ImageOptions.Image")));
            this.btnActualizarDatos.Location = new System.Drawing.Point(6, 9);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(165, 45);
            this.btnActualizarDatos.TabIndex = 151;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnActualizarDatos);
            this.panelControl.Location = new System.Drawing.Point(560, 461);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(785, 64);
            this.panelControl.TabIndex = 175;
            // 
            // FrmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcDatosUsuario);
            this.Controls.Add(this.gcDatos);
            this.Name = "FrmGestionUsuario";
            this.Text = "Gestión Usuario";
            this.Load += new System.EventHandler(this.FrmGestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).EndInit();
            this.gcDatos.ResumeLayout(false);
            this.gcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosUsuario)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDatos;
        private DevExpress.XtraEditors.SearchLookUpEdit slueEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colNumIdentidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIdUsuario;
        private DevExpress.XtraGrid.GridControl gcDatosUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatosUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colContrasena;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpleado;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        internal DevExpress.XtraEditors.SimpleButton btnNuevo;
        internal DevExpress.XtraEditors.SimpleButton btnGuardar;
        internal DevExpress.XtraEditors.SimpleButton btnCancelar;
        internal DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        internal DevExpress.XtraEditors.SimpleButton btnActualizarDatos;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}