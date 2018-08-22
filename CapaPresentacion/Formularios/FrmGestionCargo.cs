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
    public partial class FrmGestionCargo : DevExpress.XtraEditors.XtraForm
    {
        public FrmGestionCargo()
        {
            InitializeComponent();            
        }

        public delegate void DoEvent();
        public event DoEvent LlenarCbx;
        public Boolean llamado = false;

        private void Limpiar()
        {
            txtIdCargo.EditValue = "";
            txtCargo.EditValue = "";
        }
        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean group, Boolean grid)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
            gcDatosCargos.Enabled = grid;
        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtCargo.EditValue.ToString().Trim()))
            {
                txtCargo.ErrorText = "Ingre el nombre del cargo.";
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, true, true, false);
            txtCargo.Focus();
        }

        private void ListadoCargo()
        {
            CNCargo objC = new CNCargo();
            gcDatosCargos.DataSource = objC.ListadoCargo().Tables["Cargo"];
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNCargo objInsertarCargo = new CNCargo();
                CECargo objCargo = new CECargo()
                {
                    Cargo = txtCargo.Text.Trim()
                };

                if (objInsertarCargo.NuevoCargo(objCargo) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    XtraMessageBox.Show("Registro almacenado satisfactoriamente.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void MostrarCargo(int idCargo)
        {
            CNCargo objObtenerCargo = new CNCargo();
            CECargo objCargo = objObtenerCargo.ObtenerCargo(idCargo);

            txtIdCargo.EditValue = objCargo.IdCargo;
            txtCargo.EditValue = objCargo.Cargo.Trim();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(true, false, false, false, false, true);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvDatosCargo.GetRowCellValue(gvDatosCargo.FocusedRowHandle, colIdCargo).ToString());
            MostrarCargo(id);
            HabilitarControles(false, false, true, true, true, false);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNCargo objActualizarCargo = new CNCargo();
                CECargo objCargo = new CECargo()
                {
                    IdCargo = int.Parse(txtIdCargo.Text.Trim()),
                    Cargo = txtCargo.Text.Trim()
                };
                
                if(objActualizarCargo.ActualizarCargo(objCargo) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoCargo();
                    XtraMessageBox.Show("Registrro actualizado satisfactoriamente.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    XtraMessageBox.Show("Error al actualizar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CNCargo objEliminarCargo = new CNCargo();
            int id = int.Parse(gvDatosCargo.GetRowCellValue(gvDatosCargo.FocusedRowHandle, colIdCargo).ToString());
            CECargo objCargo = new CECargo()
            {
                IdCargo = id
            };

            if(objEliminarCargo.ElimarCargo(objCargo) > 0)
            {
                ListadoCargo();
                XtraMessageBox.Show("Registro eliminado satisfactoriamente", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Error al eliminar el registro", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGestionCargo_Load(object sender, EventArgs e)
        {            
            Limpiar();//Por que algunos controles tiene EditValue null, entonces le asignamos ""
            ListadoCargo();
        }

        private void FrmGestionCargo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (llamado)
                LlenarCbx();

        }
    }
}