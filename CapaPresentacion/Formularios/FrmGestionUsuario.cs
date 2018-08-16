using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaNegocio;
using CapaEntidad;
using System.Security.Cryptography;

namespace CapaPresentacion.Formularios
{
    public partial class FrmGestionUsuario : DevExpress.XtraEditors.XtraForm
    {
        public FrmGestionUsuario()
        {
            InitializeComponent();
        }

        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            LlenarComboEmpleado();
            ListadoUsuario();
            Limpiar();
            
        }

        private void Limpiar()
        {
            txtIdUsuario.EditValue = "";
            txtUsuario.EditValue = "";
            txtContrasena.EditValue = "";
            slueEmpleado.EditValue = null;
        }

        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean group, Boolean grid)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
            gcDatosUsuario.Enabled = grid;
        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtContrasena.EditValue.ToString().Trim()))
            {
                txtContrasena.ErrorText = "Ingrese la contraseña";
                return false;
            }
            if (String.IsNullOrEmpty(txtUsuario.EditValue.ToString().Trim()))
            {
                txtUsuario.ErrorText = "Ingrese el usuario";
                return false;
            }
            if (slueEmpleado.EditValue == null)
            {
                slueEmpleado.ErrorText = "Seleccione el Empleado";
                return false;
            }
            return true;
        }
        private void LlenarComboEmpleado()
        {
            CNUsuario objU = new CNUsuario();
            slueEmpleado.Properties.DataSource = objU.ListadoEmpleado().Tables["Empleado"];
        }

        public string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private void ListadoUsuario()
        {
            CNUsuario objU = new CNUsuario();
            gcDatosUsuario.DataSource = objU.ListadoUsuario().Tables["Usuario"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNUsuario objInsertarUsuario = new CNUsuario();
                CEUsuario objUsuario = new CEUsuario()
                {
                    
                    Usuario = txtUsuario.Text.Trim(),
                    Contrasena = Hash(txtContrasena.Text.Trim()),
                    NumeroIdentidadEmpleado = slueEmpleado.EditValue.ToString(),
                    Estado = chkEstado.Checked
                };

                if (objInsertarUsuario.NuevoUsuario(objUsuario) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoUsuario();
                    XtraMessageBox.Show("Registro almacenado satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void MostrarUsuario(int IdUsuario)
        {
            CNUsuario objObtenerUsuario = new CNUsuario();
            CEUsuario objUsuario = objObtenerUsuario.ObtenerUsuario(IdUsuario);
            txtIdUsuario.EditValue = objUsuario.IdUsuario;
            txtUsuario.EditValue = objUsuario.Usuario.Trim();
            slueEmpleado.EditValue = objUsuario.NumeroIdentidadEmpleado.Trim();
            chkEstado.Checked = objUsuario.Estado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNUsuario objActualizarUsuario = new CNUsuario();
                CEUsuario objUsuario = new CEUsuario()
                {
                    IdUsuario = int.Parse(txtIdUsuario.Text),
                    Usuario = txtUsuario.Text.Trim(),
                    Contrasena = Hash(txtContrasena.Text.Trim()),
                    NumeroIdentidadEmpleado = slueEmpleado.EditValue.ToString(),
                    Estado = chkEstado.Checked
                };

                if (objActualizarUsuario.ActualizarUsuario(objUsuario) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoUsuario();
                    XtraMessageBox.Show("Registro actualizado satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al actualizar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvDatosUsuario.GetRowCellValue(gvDatosUsuario.FocusedRowHandle, colIdUsuario).ToString());
            MostrarUsuario(id);
            HabilitarControles(false, false, true, true, true, false);
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            ListadoUsuario();
            LlenarComboEmpleado();
            Limpiar();

        }

        private void slueEmpleado_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = slueEmpleado.Properties.NullText;
                slueEmpleado.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = slueEmpleado.Properties.NullText;
                slueEmpleado.EditValue = "";
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
        }
    }
}
