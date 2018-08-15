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
using CapaDatos;
namespace CapaPresentacion.Formularios
{
    public partial class FrmGestionSacramentos : DevExpress.XtraEditors.XtraForm
    {
        public List<String> camposPermitidos;
        public Boolean nuevoRegistro = true;
        public String padrinoAnterior;
        public String madrinaAnterior;
        public FrmGestionSacramentos()
        {
            InitializeComponent();            
        }
        private void FrmGestionSacramentos_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
            LlenarGridSacramentos();
            padrinoAnterior = "";
            madrinaAnterior = "";
        }

        private void LlenarCombobox()
        {
            CNSacramento objS = new CNSacramento();

            lueSacramentos.Properties.DataSource = objS.ListadoSacramentos().Tables["Sacramentos"];

            slueMadrina.Properties.DataSource = objS.ListadoFeligresSexo(1).Tables["Feligres"];
            sluePadrino.Properties.DataSource = objS.ListadoFeligresSexo(2).Tables["Feligres"];

            slueFeligres.Properties.DataSource = objS.ListadoTodoFeligreses().Tables["ListadoFeligres"];

            slueEmpleado.Properties.DataSource = objS.ListadoEmpleado().Tables["Empleados"];

            lueLugar.Properties.DataSource = objS.ListadoLugar().Tables["Lugar"];
        }
        
        private void LlenarGridSacramentos()
        {
            CNSacramento objS = new CNSacramento();

            gcDatosSacramentos.DataSource = objS.ListadoRegistroSacramentos().Tables["ListadoRegistroSacramentos"];
        }

        private void Limpiar()
        {
            txtIdRegistro.EditValue = "";
            lueSacramentos.EditValue = null;
            slueFeligres.EditValue = "";
            deFecha.EditValue = "";
            lueLugar.EditValue = null;
            slueEmpleado.EditValue = "";
            sluePadrino.EditValue = "";
            slueMadrina.EditValue = "";
            txtNumLibro.EditValue = "";
            txtNumPagina.EditValue = "";
            txtNumActa.EditValue = "";
        }
        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean group, Boolean grid)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
            gcDatosSacramentos.Enabled = grid;
        }
        private Boolean Validar()
        {
            if(lueSacramentos.EditValue == null)
            {
                lueSacramentos.ErrorText = "Seleccione un sacramento";
                return false;
            }

            if (String.IsNullOrEmpty(slueFeligres.EditValue.ToString().Trim()))
            {
                slueFeligres.ErrorText = "Seleccione el feligrés.";
                return false;
            }
            if (String.IsNullOrEmpty(deFecha.EditValue.ToString().Trim()))
            {
                deFecha.ErrorText = "Seleccione la fecha del sacramento.";
                return false;
            }

            if(lueLugar.EditValue == null)
            {
                lueLugar.ErrorText = "Seleccione el lugar.";
                return false;
            }

            if (String.IsNullOrEmpty(slueEmpleado.EditValue.ToString().Trim()))
            {
                slueEmpleado.ErrorText = "Selecciones el sacerdote.";
                return false;
            }

            if(lueSacramentos.ItemIndex != 1)
            {
                if (String.IsNullOrEmpty(sluePadrino.EditValue.ToString().Trim()) && String.IsNullOrEmpty(slueMadrina.EditValue.ToString().Trim()))
                {
                    sluePadrino.ErrorText = "Seleccione por lo menos el padrino o madrina.";
                    slueMadrina.ErrorText = "Seleccione por lo menos el padrino o madrina.";
                    return false;
                }
                //if (String.IsNullOrEmpty(slueMadrina.EditValue.ToString().Trim()))
                //{
                //    slueMadrina.ErrorText = "Seleccion la madrina.";
                //    return false;
                //}
            }

            if (sluePadrino.EditValue.Equals(slueFeligres.EditValue))
            {
                sluePadrino.ErrorText = "No puede ser el mismo feligres a realizar el sacramento";
                sluePadrino.Focus();
                return false;
            }

            if (slueMadrina.EditValue.Equals(slueFeligres.EditValue))
            {
                slueMadrina.ErrorText = "No puede ser el mismo feligres a realizar el sacramento";
                slueMadrina.Focus();
                return false;
            }
            if (txtNumLibro.EditValue.Equals(""))
            {
                txtNumLibro.ErrorText = "Por favor escriba el número del libro";
                return false;
            }

            if (txtNumPagina.EditValue.Equals(""))
            {
                txtNumPagina.ErrorText = "Por favor escriba el número de página";
                return false;
            }

            if (txtNumActa.EditValue.Equals(""))
            {
                txtNumActa.ErrorText = "Por favor escriba el número de acta";
                return false;
            }

            return true;
        }

        private void MostrarUnSacramento(int id)
        {
            CNFeligres feligres = new CNFeligres();
            CNSacramento objObtenerSacramento = new CNSacramento();
            CESacramento objSacramento = objObtenerSacramento.ObtenerSacramento(id);
            List<CEPadrinoPorFeligres> objPadrinos = objObtenerSacramento.ObtenerPadrinosFeligres(id);
            CESacramentoPorFeligres objFeligres = objObtenerSacramento.ObtenerFeligresSacramento(id);
            
            txtIdRegistro.EditValue = objSacramento.Id_Registro_Sacramento;
            lueSacramentos.EditValue = objSacramento.Id_Sacramento;
            deFecha.EditValue = objSacramento.Fecha;
            slueEmpleado.EditValue = objSacramento.Num_Identidad.ToString().Trim();
            lueLugar.EditValue = objSacramento.Id_Lugar;
            txtNumLibro.EditValue = objSacramento.Numero_Libro;
            txtNumPagina.EditValue = objSacramento.Numero_Pagina;
            txtNumActa.EditValue = objSacramento.Numero_Acta;

            slueFeligres.EditValue = objFeligres.Feligres_Num_Identidad.ToString().Trim();

            if(objPadrinos.Count == 1)
            {
                CEFeligres padrino = feligres.ObtenerFeligres(objPadrinos[0].Feligres_Num_Identidad);
                if (padrino.IdSexo == 1)
                {
                    slueMadrina.EditValue = objPadrinos[0].Feligres_Num_Identidad;
                }
                else
                {
                    sluePadrino.EditValue = objPadrinos[0].Feligres_Num_Identidad;
                }
            }
            else if(objPadrinos.Count == 2)
            {
                CEFeligres padrino = feligres.ObtenerFeligres(objPadrinos[0].Feligres_Num_Identidad);
                if(padrino.IdSexo == 1)
                {
                    slueMadrina.EditValue = objPadrinos[0].Feligres_Num_Identidad;
                    sluePadrino.EditValue = objPadrinos[1].Feligres_Num_Identidad;
                }
                else
                {
                    sluePadrino.EditValue = objPadrinos[0].Feligres_Num_Identidad;
                    slueMadrina.EditValue = objPadrinos[1].Feligres_Num_Identidad;
                }
            }
            
        }
        private void validarSoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void camposActivos(Boolean valor)
        {
            slueMadrina.Enabled = valor;
            sluePadrino.Enabled = valor;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            Funciones.Funciones.ExportarPDF(gcDatosSacramentos, "Sacramentos");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Funciones.Funciones.ExportarExcel(gcDatosSacramentos, "Sacramentos");
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            gcDatosSacramentos.ShowPrintPreview();
        }

        private void sluePadrino_EditValueChanged(object sender, EventArgs e)
        {
            if(sluePadrino.EditValue.Equals(slueFeligres.EditValue))
            {
                sluePadrino.ErrorText = "No puede ser el mismo feligres a realizar el sacramento";
                sluePadrino.Focus();
                return;
            }
        }

        private void slueMadrina_EditValueChanged(object sender, EventArgs e)
        {
            if (slueMadrina.EditValue.Equals(slueFeligres.EditValue))
            {
                slueMadrina.ErrorText = "No puede ser el mismo feligres a realizar el sacramento";
                slueMadrina.Focus();
                return;
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
            slueFeligres.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CNSacramento objInsertarRegistro = new CNSacramento();
            
            CESacramentoPorFeligres objSF = new CESacramentoPorFeligres()
            {
                Feligres_Num_Identidad = slueFeligres.EditValue.ToString().Trim()
            };
            
            if(objInsertarRegistro.Existe_Registro(objSF, int.Parse(lueSacramentos.EditValue.ToString())))
            {
                XtraMessageBox.Show("Este feligrés ya tiene registrado este sacramento.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Validate();
                if (Validar())
                {
                    int idRegistro;
                    int resultado = 1;

                    CESacramento objSacramento = new CESacramento()
                    {
                        Id_Sacramento = int.Parse(lueSacramentos.EditValue.ToString()),
                        Fecha = deFecha.DateTime.Date,
                        Num_Identidad = slueEmpleado.EditValue.ToString(),
                        Id_Lugar = int.Parse(lueLugar.EditValue.ToString()),
                        Numero_Libro = int.Parse(txtNumLibro.EditValue.ToString()),
                        Numero_Pagina = int.Parse(txtNumPagina.EditValue.ToString()),
                        Numero_Acta = int.Parse(txtNumActa.EditValue.ToString()),
                        Id_Usuario = Funciones.Funciones.idUsuario
                    };

                    idRegistro = objInsertarRegistro.NuevoRegistroSacramento(objSacramento);

                    CESacramentoPorFeligres objSacramentoFeligres = new CESacramentoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = slueFeligres.EditValue.ToString()
                    };

                    CEPadrinoPorFeligres objPadrino = new CEPadrinoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = sluePadrino.EditValue.ToString(),
                        De_Novio = false
                    };

                    CEPadrinoPorFeligres objMadrina = new CEPadrinoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = slueMadrina.EditValue.ToString(),
                        De_Novio = false
                    };

                    if (objInsertarRegistro.RegistroSacramentoPorFeligres(objSacramentoFeligres) > 0)
                    {
                        if (objPadrino.Feligres_Num_Identidad != "")
                        {
                            resultado = objInsertarRegistro.RegistroPadrinoPorFeligres(objPadrino);
                        }

                        if (objMadrina.Feligres_Num_Identidad != "")
                        {
                            resultado = objInsertarRegistro.RegistroPadrinoPorFeligres(objMadrina);
                        }

                        if (resultado > 0)
                        {
                            XtraMessageBox.Show("Registro almacenado satisfactoriamente.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Error al almacenar el registro.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Limpiar();
                        HabilitarControles(true, false, false, false, false, true);
                        LlenarGridSacramentos();
                    }
                    else
                    {
                        XtraMessageBox.Show("Error al almacenar el registro.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }           
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sacramento = gvDatosSacramentos.GetRowCellValue(gvDatosSacramentos.FocusedRowHandle, colSacramento).ToString();
            int id = int.Parse(gvDatosSacramentos.GetRowCellValue(gvDatosSacramentos.FocusedRowHandle, colIdRegistroSacramento).ToString());
            int idSacramento = int.Parse(gvDatosSacramentos.GetRowCellValue(gvDatosSacramentos.FocusedRowHandle, colIdSacramento).ToString());
            if (sacramento != "Matrimonio")
            {                
                MostrarUnSacramento(id);
                HabilitarControles(false, false, true, true, true, false);
                slueFeligres.Enabled = false;
            }
            else
            {
                FrmMatrimonio frm = new FrmMatrimonio();
                frm.idRegistro = id;
                frm.idSacramento = idSacramento;
                frm.nuevoRegistro = false;
                frm.ShowDialog();
                frm.Focus();
                Limpiar();
                LlenarGridSacramentos();
                LlenarCombobox();
                HabilitarControles(true, false, false, false, false, true);                
            }
            padrinoAnterior = sluePadrino.EditValue.ToString();
            madrinaAnterior = slueMadrina.EditValue.ToString(); 
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            LlenarGridSacramentos();
            LlenarCombobox();
            Limpiar();
        }

        private void lueSacramentos_TextChanged(object sender, EventArgs e)
        {
            if (lueSacramentos.ItemIndex == 1)
            {
                camposActivos(false);
            }
            else if (lueSacramentos.ItemIndex == 3)
            {
                FrmMatrimonio frm = new FrmMatrimonio();
                frm.idSacramento = 4;
                frm.ShowDialog();
                frm.Focus();
                Limpiar();
                LlenarCombobox();
                LlenarGridSacramentos();
                HabilitarControles(true, false, false, false, false, true);
            }
            else
            {
                camposActivos(true);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                int idRegistro;

                CNSacramento objActualizarRegistro = new CNSacramento();
                CESacramento objSacramento = new CESacramento()
                {
                    Id_Registro_Sacramento = int.Parse(txtIdRegistro.EditValue.ToString()),
                    Id_Sacramento = int.Parse(lueSacramentos.EditValue.ToString()),
                    Fecha = deFecha.DateTime.Date,
                    Num_Identidad = slueEmpleado.EditValue.ToString(),
                    Id_Lugar = int.Parse(lueLugar.EditValue.ToString()),
                    Numero_Libro = int.Parse(txtNumLibro.EditValue.ToString()),
                    Numero_Pagina = int.Parse(txtNumPagina.EditValue.ToString()),
                    Numero_Acta = int.Parse(txtNumActa.EditValue.ToString()),
                    Id_Usuario = Funciones.Funciones.idUsuario
                };
                
                idRegistro = int.Parse(txtIdRegistro.EditValue.ToString());
          
                CESacramentoPorFeligres objSacramentoFeligres = new CESacramentoPorFeligres()
                {
                    Id_Registro_Sacramento = idRegistro,
                    Feligres_Num_Identidad = slueFeligres.EditValue.ToString()
                };

                CEPadrinoPorFeligres objPadrino = new CEPadrinoPorFeligres()
                {
                    Id_Registro_Sacramento = idRegistro,
                    Feligres_Num_Identidad = sluePadrino.EditValue.ToString()
                };

                CEPadrinoPorFeligres objMadrina = new CEPadrinoPorFeligres()
                {
                    Id_Registro_Sacramento = idRegistro,
                    Feligres_Num_Identidad = slueMadrina.EditValue.ToString()
                };

                if (objActualizarRegistro.ActualizarRegistroSacramento(objSacramento) > 0)
                {
                    if(objPadrino.Feligres_Num_Identidad != "" && String.IsNullOrEmpty(padrinoAnterior))
                    {
                        objActualizarRegistro.InsertarPadrinoPorFeligresNovios(objPadrino);
                    }
                    else if(objPadrino.Feligres_Num_Identidad != "")
                    {
                        objActualizarRegistro.ActualizarPadrinosPorFeligres(objPadrino, padrinoAnterior);
                    }

                    if (objMadrina.Feligres_Num_Identidad != "" && String.IsNullOrEmpty(madrinaAnterior))
                    {
                        objActualizarRegistro.InsertarPadrinoPorFeligresNovios(objMadrina);
                    }
                    else if(objMadrina.Feligres_Num_Identidad != "")
                    {
                        objActualizarRegistro.ActualizarPadrinosPorFeligres(objMadrina, madrinaAnterior);
                    }

                    XtraMessageBox.Show("Registro actualizado satisfactoriamente.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    slueFeligres.Enabled = true;
                    LlenarGridSacramentos();
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar el registro.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FrmGestionFeligres frm = new FrmGestionFeligres();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmGestionFeligres frm = new FrmGestionFeligres();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmGestionFeligres frm = new FrmGestionFeligres();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.Focus();
        }

        private void slueFeligres_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = slueFeligres.Properties.NullText;
                slueFeligres.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = slueFeligres.Properties.NullText;
                slueFeligres.EditValue = "";
            }
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

        private void sluePadrino_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = sluePadrino.Properties.NullText;
                sluePadrino.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = sluePadrino.Properties.NullText;
                sluePadrino.EditValue = "";
            }
        }

        private void slueMadrina_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = slueMadrina.Properties.NullText;
                slueMadrina.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = slueMadrina.Properties.NullText;
                slueMadrina.EditValue = "";
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idRegistro = int.Parse(gvDatosSacramentos.GetRowCellValue(gvDatosSacramentos.FocusedRowHandle, colIdRegistroSacramento).ToString());
            String sacramento = gvDatosSacramentos.GetRowCellValue(gvDatosSacramentos.FocusedRowHandle, colSacramento).ToString();

            CDReportes objR = new CDReportes();
            if (sacramento.Equals("Matrimonio"))
            {

                CERptMatrimonio obj = objR.MostrarReporteMatrimonio(idRegistro);
                Reportes.RptMatrimonio reporte = new Reportes.RptMatrimonio(obj);
                Funciones.Funciones.MostrarReportes("Reporte de Matrimonio", reporte, this.MdiParent, false);
            }
            else if (sacramento.Equals("Primera comunión"))
            {

                CERptPrimeraComunion obj = objR.MostrarReportePrimeraComunion(idRegistro);
                Reportes.RptPrimeraComunion reporte = new Reportes.RptPrimeraComunion(obj);
                Funciones.Funciones.MostrarReportes("Reporte de Primera comunión", reporte, this.MdiParent, false);
            }
            else if (sacramento.Equals("Bautismo"))
            {
                CERptBautismo obj = objR.MostrarReporteBautismo(idRegistro);
                Reportes.RptBautismo reporte = new Reportes.RptBautismo(obj);
                Funciones.Funciones.MostrarReportes("Reporte de Bautismo", reporte, this.MdiParent, false);
            }
            else
            {
                CERptConfirmacion obj = objR.MostrarReporteConfirmacion(idRegistro);
                Reportes.RptConfirmacion reporte = new Reportes.RptConfirmacion(obj);
                Funciones.Funciones.MostrarReportes("Reporte de Confirmación", reporte, this.MdiParent, false);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmGestionEmpleado frm = new FrmGestionEmpleado();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.Focus();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FrmGestionLugar frm = new FrmGestionLugar();
            frm.ShowDialog();
            frm.Focus();
        }
    }
}