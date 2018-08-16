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
using System.IO;

namespace CapaPresentacion.Formularios
{
    public partial class FrmDatosGenerales : DevExpress.XtraEditors.XtraForm
    {
        public FrmDatosGenerales()
        {
            InitializeComponent();
        }

        private void FrmDatosGenerales_Load(object sender, EventArgs e)
        {
            HabilitarControles(true, true, true);
            CargarDatosGenerales();
        }
        private void CargarDatosGenerales()
        {
            CNDatosGenerales objDatos = new CNDatosGenerales();
            CEDatosGenerales objDatosG = new CEDatosGenerales();

            objDatosG = objDatos.Mostrar_Datos();

            txtNombre.EditValue = objDatosG.Nombre_Parroquia;
            meDireccion.EditValue = objDatosG.Direccion;
            txtTelefono.EditValue = objDatosG.Telefono;
            this.Text = objDatosG.Nombre_Parroquia;

            MemoryStream ms = new MemoryStream((byte[])objDatosG.Logo);
            pELogo.Image = Image.FromStream(ms);

            cEUsarLogo.Checked = objDatosG.Usa_Logo;
        }
        private void HabilitarControles(Boolean guardar, Boolean cancelar, Boolean group)
        {
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de imagen(*.jpg, *.png, *.jpeg)|*.jpg; *.png; *.jpeg";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pELogo.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pELogo.Image = null;
        }
        private void Limpiar()
        {
            txtNombre.EditValue = "";
            meDireccion.EditValue = "";
            txtTelefono.EditValue = "";
            pELogo.Image = null;
        }
        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtNombre.EditValue.ToString().Trim()))
            {
                txtNombre.ErrorText = "Ingrese el apellido";
                return false;
            }

            if (String.IsNullOrEmpty(txtNombre.EditValue.ToString().Trim()))
            {
                txtNombre.ErrorText = "Ingrese el apellido";
                return false;
            }

            if (String.IsNullOrEmpty((meDireccion.EditValue.ToString().Trim())))
            {
                meDireccion.ErrorText = "Ingrese la dirección";
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (pELogo.Image != null)
            {
                pELogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                pELogo.Image = Properties.Resources.general;
                pELogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            this.Validate();
            if (Validar())
            {
                CNDatosGenerales objNegocioDatos = new CNDatosGenerales();
                CEDatosGenerales objDatosG = new CEDatosGenerales()
                {
                    Id_Dato = Convert.ToInt32(1),
                    Nombre_Parroquia = txtNombre.Text.Trim(),
                    Direccion = meDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Id_Usuario = Convert.ToInt32(6),
                    Logo = ms.GetBuffer(),
                    Usa_Logo = cEUsarLogo.Checked
                };

                if (objNegocioDatos.Guardar_Datos_Generales(objDatosG) > 0)
                {
                    Limpiar();
                    XtraMessageBox.Show("Registro almacenado satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar los datos.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }
    }
}