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

namespace CapaPresentacion.Formularios
{
    public partial class FrmGestionFeligres : DevExpress.XtraEditors.XtraForm
    {
        public FrmGestionFeligres()
        {
            InitializeComponent();
        }

        private void FrmGestionFeligres_Load(object sender, EventArgs e)
        {
            LlenarComboSexo();
            LlenarComboPadres();
            Limpiar();//Por que algunos controles tiene EditValue null, entonces le asignamos ""
            ListadoFeligres();
        }

        private void Limpiar()
        {
            txtNumeroIdentidad.EditValue = "";
            txtNombre.EditValue = "";
            txtApellido.EditValue = "";
            meDireccion.EditValue = "";
            deFechaNac.EditValue = "";
            txtTelefono.EditValue = "";
            txtCorreo.EditValue = "";
            lueSexo.EditValue = null;
            sluePadre.EditValue = "";
            slueMadre.EditValue = "";
        }

        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean group, Boolean grid)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
            gcDatosFeligres.Enabled = grid;
        }

        private Boolean Validar()
        {
            if(String.IsNullOrEmpty(txtNumeroIdentidad.EditValue.ToString().Trim()))
            {
                txtNumeroIdentidad.ErrorText = "Ingrese el numéro de identidad";
                return false;
            }
            if (String.IsNullOrEmpty(txtNombre.EditValue.ToString().Trim()))
            {
                txtNombre.ErrorText = "Ingrese el nombre";
                return false;
            }
            if (String.IsNullOrEmpty(txtApellido.EditValue.ToString().Trim()))
            {
                txtApellido.ErrorText = "Ingrese el apellido";
                return false;
            }
            if (String.IsNullOrEmpty((meDireccion.EditValue.ToString().Trim())))
            {
                meDireccion.ErrorText = "Ingrese la dirección";
                return false;
            }
            if (String.IsNullOrEmpty(deFechaNac.EditValue.ToString().Trim()))
            {
                deFechaNac.ErrorText = "Ingrese la fecha de nacimiento";
                return false;
            }
            if (lueSexo.EditValue == null)
            {
                lueSexo.ErrorText = "Seleccione el sexo";
                return false;
            }
            /*if (String.IsNullOrEmpty(sluePadre.EditValue.ToString().Trim()))
            {
                sluePadre.ErrorText = "Seleccione el padre";
                return false;
            }
            if (String.IsNullOrEmpty(slueMadre.EditValue.ToString().Trim()))
            {
                slueMadre.ErrorText = "Seleccione la madre";
                return false;
            }*/
            // Lo comenté, por que no es obligatorio.

            if (sluePadre.EditValue.ToString().Trim().Equals(txtNumeroIdentidad.EditValue.ToString()))
            {
                sluePadre.ErrorText = "Seleccione un padre correcto";
                return false;
            }
            if (slueMadre.EditValue.ToString().Trim().Equals(txtNumeroIdentidad.EditValue.ToString()))
            {
                slueMadre.ErrorText = "Seleccione una madre correcto";
                return false;
            }
            return true;
        }
        private void LlenarComboSexo()
        {
            CNFeligres objF = new CNFeligres();
            lueSexo.Properties.DataSource = objF.ListadoSexo().Tables["Sexo"];
        }
        private void LlenarComboPadres()
        {
            CNFeligres objF = new CNFeligres();
            sluePadre.Properties.DataSource = objF.ListadoFeligresSexo(2).Tables["Feligres"];
            slueMadre.Properties.DataSource = objF.ListadoFeligresSexo(1).Tables["Feligres"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNFeligres objInsertarFeligres = new CNFeligres();
                CEFeligres objFeligres = new CEFeligres()
                {
                    NumeroIdentidad = txtNumeroIdentidad.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Direccion = meDireccion.Text.Trim(),
                    FechaNacimiento = deFechaNac.DateTime.Date,
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    IdSexo = int.Parse(lueSexo.EditValue.ToString()),
                    NumeroIdentidadPadre = sluePadre.EditValue.ToString(),
                    NumeroIdentidadMadre = slueMadre.EditValue.ToString(),
                    Estado = chkEstado.Checked
                };

                if (objInsertarFeligres.NuevoFeligres(objFeligres) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoFeligres();
                    XtraMessageBox.Show("Registro almacenado satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }
        public void MostrarFeligres(String numeroIdentidad)
        {
            CNFeligres objObtenerFeligres = new CNFeligres();
            CEFeligres objFeligres = objObtenerFeligres.ObtenerFeligres(numeroIdentidad.Trim());
            txtNumeroIdentidad.EditValue = objFeligres.NumeroIdentidad.Trim();
            txtNombre.EditValue = objFeligres.Nombre.Trim();
            txtApellido.EditValue = objFeligres.Apellido.Trim();
            meDireccion.EditValue = objFeligres.Direccion.Trim();
            deFechaNac.EditValue = objFeligres.FechaNacimiento;
            txtTelefono.EditValue = objFeligres.Telefono.Trim();
            txtCorreo.EditValue = objFeligres.Correo.Trim();
            lueSexo.EditValue = objFeligres.IdSexo;
            sluePadre.EditValue = objFeligres.NumeroIdentidadPadre.Trim();
            slueMadre.EditValue = objFeligres.NumeroIdentidadMadre.Trim();
            chkEstado.Checked = objFeligres.Estado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNFeligres objActualizarFeligres = new CNFeligres();
                CEFeligres objFeligres = new CEFeligres()
                {
                    NumeroIdentidad = txtNumeroIdentidad.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Direccion = meDireccion.Text.Trim(),
                    FechaNacimiento = deFechaNac.DateTime.Date,
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    IdSexo = int.Parse(lueSexo.EditValue.ToString()),
                    NumeroIdentidadPadre = sluePadre.EditValue.ToString(),
                    NumeroIdentidadMadre = slueMadre.EditValue.ToString(),
                    Estado = chkEstado.Checked
                };

                if (objActualizarFeligres.ActualizarFeligres(objFeligres) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    txtNumeroIdentidad.Enabled = !false;
                    ListadoFeligres();
                    XtraMessageBox.Show("Registro actualizado satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al actualizar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CNFeligres objEliminarFeligres = new CNFeligres();
            String id = gvDatosFeligres.GetRowCellValue(gvDatosFeligres.FocusedRowHandle, colNumIdentidad).ToString();
            CEFeligres objFeligres = new CEFeligres()
            {
                NumeroIdentidad = id
            };

            if (objEliminarFeligres.EliminarFeligres(objFeligres) > 0)
            {
                ListadoFeligres();
                XtraMessageBox.Show("Registro eliminado satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Error al eliminar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = gvDatosFeligres.GetRowCellValue(gvDatosFeligres.FocusedRowHandle, colNumIdentidad).ToString();
            MostrarFeligres(id);
            HabilitarControles(false, false, true, true, true, false);
            txtNumeroIdentidad.Enabled = false;
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            ListadoFeligres();
            LlenarComboPadres();
            LlenarComboSexo();
            Limpiar();

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            Funciones.Funciones.ExportarPDF(gcDatosFeligres, "Feligreses");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Funciones.Funciones.ExportarExcel(gcDatosFeligres, "Feligreses");
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            gcDatosFeligres.ShowPrintPreview();
        }
        private void ListadoFeligres()
        {
            CNFeligres objF = new CNFeligres();
            gcDatosFeligres.DataSource = objF.ListadoFeligres().Tables["Feligres"];
        }

        private void sluePadre_CustomDisplayText_1(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {   if (e.Value == null)
            {
                e.DisplayText = sluePadre.Properties.NullText;
                sluePadre.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = sluePadre.Properties.NullText;
                sluePadre.EditValue = "";
            }
        }

        private void slueMadre_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
            {
                e.DisplayText = sluePadre.Properties.NullText;
                slueMadre.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = slueMadre.Properties.NullText;
                slueMadre.EditValue = "";
            }
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
            txtNumeroIdentidad.Enabled = !false;
        }
    }
}