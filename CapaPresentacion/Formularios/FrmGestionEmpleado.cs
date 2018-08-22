using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaNegocio;
using CapaEntidad;
using CapaPresentacion.Formularios;

namespace CapaPresentacion
{
    public partial class FrmGestionEmpleado : DevExpress.XtraEditors.XtraForm
    {
        public FrmGestionEmpleado()
        {
            InitializeComponent();
        }

        private void FrmGestionEmpleado_Load(object sender, EventArgs e)
        {
            LlenarComboSexo();
            LlenarComboCargo();
            Limpiar();
            ListadoEmpleado();
        }

        private void LlenarComboSexo()
        {
            CNEmpleado objE = new CNEmpleado();
            lueSexo.Properties.DataSource = objE.ListadoSexo().Tables["Sexo"];
        }

        private void LlenarComboCargo()
        {
            CNEmpleado objE = new CNEmpleado();
            lueCargo.Properties.DataSource = objE.ListadoCargo().Tables["Cargo"];
        }
        private void Limpiar()
        {
            txtNumeroIdentidad.EditValue = "";
            txtNombre.EditValue = "";
            txtApellido.EditValue = "";
            meDireccion.EditValue = "";
            txtTelefono.EditValue = "";
            txtCorreo.EditValue = "";
            lueSexo.EditValue = null;
            lueCargo.EditValue = null;
        }
        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean group, Boolean grid)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
            gcDatosEmpleado.Enabled = grid;
        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtNumeroIdentidad.EditValue.ToString().Trim()))
            {
                txtNumeroIdentidad.ErrorText = "Ingrese el Numéro de Identidad";
                return false;
            }
            if (String.IsNullOrEmpty(txtNombre.EditValue.ToString().Trim()))
            {
                txtNombre.ErrorText = "Ingrese el Nombre";
                return false;
            }
            if (String.IsNullOrEmpty(txtApellido.EditValue.ToString().Trim()))
            {
                txtApellido.ErrorText = "Ingrese el Apellido";
                return false;
            }
            if (String.IsNullOrEmpty((meDireccion.EditValue.ToString().Trim())))
            {
                meDireccion.ErrorText = "Ingrese la Dirección";
                return false;
            }
            if (lueSexo.EditValue == null)
            {
                lueSexo.ErrorText = "Seleccione el Sexo";
                return false;
            }
            if (lueCargo.EditValue == null)
            {
                lueCargo.ErrorText = "Seleccione el Cargo";
                return false;
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, true, true, false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(true, false, false, false, false, true);
        }

        private void ListadoEmpleado()
        {
            CNEmpleado objE = new CNEmpleado();
            gcDatosEmpleado.DataSource = objE.ListadoEmpleado().Tables["Empleado"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNEmpleado objInsertarEmpleado = new CNEmpleado();
                CEEmpleado objEmpleado = new CEEmpleado()
                {
                    NumeroIdentidad = txtNumeroIdentidad.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Direccion = meDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    IdSexo = int.Parse(lueSexo.EditValue.ToString()),
                    IdCargo = int.Parse(lueCargo.EditValue.ToString()),
                    Estado = chkEstado.Checked
                };

                if (objInsertarEmpleado.NuevoEmpleado(objEmpleado) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoEmpleado();
                    XtraMessageBox.Show("Registro almacenado Satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar el Registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNEmpleado objActualizarEmpleado = new CNEmpleado();
                CEEmpleado objEmpleado = new CEEmpleado()
                {
                    NumeroIdentidad = txtNumeroIdentidad.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Direccion = meDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    IdSexo = int.Parse(lueSexo.EditValue.ToString()),
                    IdCargo = int.Parse(lueCargo.EditValue.ToString()),
                    Estado = chkEstado.Checked
                };

                if (objActualizarEmpleado.ActualizarEmpleado(objEmpleado) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoEmpleado();
                    XtraMessageBox.Show("Registro Actualizado Satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al Actualizar el Registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = gvDatosEmpleado.GetRowCellValue(gvDatosEmpleado.FocusedRowHandle, colNum_idem).ToString();
            MostrarEmpleado(id);
            HabilitarControles(false, false, true, true, true, false);
        }

        public void MostrarEmpleado(String numeroIdentidad)
        {
            CNEmpleado objObtenerEmpleado = new CNEmpleado();
            CEEmpleado objE = objObtenerEmpleado.ObtenerEmpleado(numeroIdentidad.Trim());
            txtNumeroIdentidad.EditValue = objE.NumeroIdentidad.Trim();
            txtNombre.EditValue = objE.Nombre.Trim();
            txtApellido.EditValue = objE.Apellido.Trim();
            meDireccion.EditValue = objE.Direccion.Trim();
            txtTelefono.EditValue = objE.Telefono.Trim();
            txtCorreo.EditValue = objE.Correo.Trim();
            lueCargo.EditValue = objE.IdCargo;
            lueSexo.EditValue = objE.IdSexo;
            chkEstado.Checked = objE.Estado;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CNEmpleado objEliminarEmpleado = new CNEmpleado();
            String id = gvDatosEmpleado.GetRowCellValue(gvDatosEmpleado.FocusedRowHandle,colNum_idem).ToString();
            CEEmpleado objEmpleado = new CEEmpleado()
            {
                NumeroIdentidad = id
            };

            if (objEliminarEmpleado.EliminarEmpleado(objEmpleado) > 0)
            {
                ListadoEmpleado();
                XtraMessageBox.Show("Registro Eliminado Satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Error al Eliminar el Registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            ListadoEmpleado();
            LlenarComboCargo();
            LlenarComboSexo();
            Limpiar();
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            Funciones.Funciones.ExportarPDF(gcDatosEmpleado, "Empleados");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Funciones.Funciones.ExportarExcel(gcDatosEmpleado, "Empleados");
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            gcDatosEmpleado.ShowPrintPreview();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FrmGestionCargo frm = new FrmGestionCargo();
            frm.LlenarCbx += new FrmGestionCargo.DoEvent(LlenarComboCargo);
            frm.llamado = true;
            frm.ShowDialog();
            frm.Focus();
        }

        private void FrmGestionEmpleado_Validated(object sender, EventArgs e)
        {
            LlenarComboCargo();
        }
    }
}