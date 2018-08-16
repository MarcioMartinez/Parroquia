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

namespace CapaPresentacion
{
    public partial class FrmGestionLugar : DevExpress.XtraEditors.XtraForm
    {
        public Boolean llamado = false;
        public FrmGestionLugar()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtIdLugar.EditValue = "";
            txtLugar.EditValue = "";
        }
        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean group, Boolean grid)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
            gcDatosLugar.Enabled = grid;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, true, true, false);
        }
        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtLugar.EditValue.ToString().Trim()))
            {
                txtLugar.ErrorText = "Ingre el nombre del Lugar.";
                return false;
            }

            return true;
        }
        private void ListadoLugar()
        {
            CNLugar objC = new CNLugar();
            gcDatosLugar.DataSource = objC.ListadoLugar().Tables["Lugar"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNLugar objInsertarLugar = new CNLugar();
                CELugar objLugar = new CELugar()
                {
                    Lugar = txtLugar.Text.Trim()
                };

                if (objInsertarLugar.NuevoLugar(objLugar) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoLugar();
                    XtraMessageBox.Show("Registro Almacenado Satisfactoriamente.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                CNLugar objActualizarLugar = new CNLugar();
                CELugar objLugar = new CELugar()
                {
                    Id_Lugar = int.Parse(txtIdLugar.Text.Trim()),
                    Lugar = txtLugar.Text.Trim()
                };

                if (objActualizarLugar.ActualizarLugar(objLugar) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoLugar();
                    XtraMessageBox.Show("Registro actualizado satisfactoriamente.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al actualizar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(true, false, false, false, false, true);
        }
        private void MostrarLugar(int idLugar)
        {
            CNLugar objObtenerLugar = new CNLugar();
            CELugar objCargo = objObtenerLugar.ObtenerLugar(idLugar);

            txtIdLugar.EditValue = objCargo.Id_Lugar;
            txtLugar.EditValue = objCargo.Lugar.Trim();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvDatosLugar.GetRowCellValue(gvDatosLugar.FocusedRowHandle, colIdLugar).ToString());
            MostrarLugar(id);
            HabilitarControles(false, false, true, true, true, false);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CNLugar objEliminarLugar = new CNLugar();
            int id = int.Parse(gvDatosLugar.GetRowCellValue(gvDatosLugar.FocusedRowHandle, colIdLugar).ToString());
            CELugar objLugar = new CELugar()
            {
                Id_Lugar = id
            };

            if (objEliminarLugar.ElimarLugar(objLugar) > 0)
            {
                ListadoLugar();
                XtraMessageBox.Show("Registro eliminado satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Error al eliminar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGestionLugar_Load(object sender, EventArgs e)
        {
            Limpiar();//Por que algunos controles tiene EditValue null, entonces le asignamos ""
            ListadoLugar();
        }

        public delegate void DoEvent();
        public event DoEvent LlenarCbx;
        private void FrmGestionLugar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (llamado)
            {
                LlenarCbx();
            }
        }
    }
}