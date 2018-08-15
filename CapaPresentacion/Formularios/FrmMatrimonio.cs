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
    public partial class FrmMatrimonio : DevExpress.XtraEditors.XtraForm
    {
        public int idSacramento;
        public int idRegistro;
        public Boolean nuevoRegistro = true;
        public String padrinoAnteriorH;
        public String madrinaAnteriorH;
        public String padrinoAnteriorM;
        public String madrinaAnteriorM;
        public FrmMatrimonio()
        {
            InitializeComponent();
        }
        private void FrmMatrimonio_Load(object sender, EventArgs e)
        {
            LlenarCombobox();

            if(nuevoRegistro == false)
            {
                MostrarDatosMatrinmonio(idRegistro);
                slueNovia.Enabled = false;
                slueNovio.Enabled = false;
                padrinoAnteriorH = sluePadrinoNovio.EditValue.ToString();
                madrinaAnteriorH = slueMadrinaNovio.EditValue.ToString();
                padrinoAnteriorM = sluePadrinoNovia.EditValue.ToString();
                madrinaAnteriorM = slueMadrinaNovia.EditValue.ToString();
                HabilitarControles(false, false, true, true, true);
            }
            else
            {
                HabilitarControles(false, true, false, true, true);
            }          
        }
        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean group)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
        }

        private bool ValidarNovios()
        {
            CNSacramento objSacramento = new CNSacramento();

            //Se toma los datos del novio para verificar si no essta casado con otra persona.
            CESacramentoPorFeligres objSNovio = new CESacramentoPorFeligres()
            {
                Feligres_Num_Identidad = slueNovio.EditValue.ToString().Trim()
            };

            //Se toma los datos del novia para verificar si no essta casado con otra persona.
            CESacramentoPorFeligres objSNovia = new CESacramentoPorFeligres()
            {
                Feligres_Num_Identidad = slueNovia.EditValue.ToString().Trim()
            };

            if (objSacramento.Existe_Registro(objSNovio, idSacramento))
            {
                slueNovio.ErrorText = "Ya está casado con otra persona.";
                return false;
            }

            if (objSacramento.Existe_Registro(objSNovia, idSacramento))
            {
                slueNovia.ErrorText = "Ya está casado con otra persona.";
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if(!ValidarNovios())
            {
                XtraMessageBox.Show("Uno de los novios ya está casado con otra persona.");
            }
            else
            {
                this.Validate();
                if (Validar())
                {
                    int idRegistro;
                    CNSacramento objInsertarRegistro = new CNSacramento();

                    CESacramento objSacramento = new CESacramento()
                    {
                        Id_Sacramento = idSacramento,
                        Fecha = deFecha.DateTime.Date,
                        Num_Identidad = slueEmpleado.EditValue.ToString(),
                        Id_Lugar = int.Parse(lueLugar.EditValue.ToString()),
                        Numero_Libro = int.Parse(txtNumLibro.EditValue.ToString()),
                        Numero_Pagina = int.Parse(txtNumPagina.EditValue.ToString()),
                        Numero_Acta = int.Parse(txtNumActa.EditValue.ToString()),
                        Id_Usuario = 6
                    };

                    if (nuevoRegistro)
                    {
                        idRegistro = objInsertarRegistro.NuevoRegistroSacramento(objSacramento);
                    }
                    else
                    {
                        idRegistro = int.Parse(txtIdRegistro.EditValue.ToString());
                    }

                    CESacramentoPorFeligres objNovio = new CESacramentoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = slueNovio.EditValue.ToString()
                    };
                    CESacramentoPorFeligres objNovia = new CESacramentoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = slueNovia.EditValue.ToString()
                    };

                    CEPadrinoPorFeligres objPadrinoNovio = new CEPadrinoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = sluePadrinoNovio.EditValue.ToString(),
                        De_Novio = true
                    };

                    CEPadrinoPorFeligres objMadrinaNovio = new CEPadrinoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = slueMadrinaNovio.EditValue.ToString(),
                        De_Novio = true
                    };
                    CEPadrinoPorFeligres objPadrinoNovia = new CEPadrinoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = sluePadrinoNovia.EditValue.ToString(),
                        De_Novio = false
                    };

                    CEPadrinoPorFeligres objMadrinaNovia = new CEPadrinoPorFeligres()
                    {
                        Id_Registro_Sacramento = idRegistro,
                        Feligres_Num_Identidad = slueMadrinaNovia.EditValue.ToString(),
                        De_Novio = false
                    };

                    if (objInsertarRegistro.RegistroSacramentoPorFeligres(objNovio) > 0 && objInsertarRegistro.RegistroSacramentoPorFeligres(objNovia) > 0)
                    {
                        if (objInsertarRegistro.InsertarPadrinoPorFeligresNovios(objPadrinoNovio) > 0 && objInsertarRegistro.InsertarPadrinoPorFeligresNovios(objMadrinaNovio) > 0 && objInsertarRegistro.InsertarPadrinoPorFeligresNovios(objPadrinoNovia) > 0 && objInsertarRegistro.InsertarPadrinoPorFeligresNovios(objMadrinaNovia) > 0)
                        {
                            XtraMessageBox.Show("Registro almacenado satisfactoriamente.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Error al almacenar el registro.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Limpiar();
                        HabilitarControles(true, false, false, false, false);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Error al almacenar el registro.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }           
        }
        private void LlenarCombobox()
        {
            CNSacramento objS = new CNSacramento();

            slueNovia.Properties.DataSource = objS.ListadoFeligresSexo(1).Tables["Feligres"];
            slueNovio.Properties.DataSource = objS.ListadoFeligresSexo(2).Tables["Feligres"];

            slueMadrinaNovio.Properties.DataSource = objS.ListadoFeligresSexo(1).Tables["Feligres"];
            sluePadrinoNovio.Properties.DataSource = objS.ListadoFeligresSexo(2).Tables["Feligres"];

            slueMadrinaNovia.Properties.DataSource = objS.ListadoFeligresSexo(1).Tables["Feligres"];
            sluePadrinoNovia.Properties.DataSource = objS.ListadoFeligresSexo(2).Tables["Feligres"];

            slueEmpleado.Properties.DataSource = objS.ListadoEmpleado().Tables["Empleados"];

            lueLugar.Properties.DataSource = objS.ListadoLugar().Tables["Lugar"];
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles(false, true, false, true, true);
        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(slueNovio.EditValue.ToString().Trim()))
            {
                slueNovio.ErrorText = "Seleccione el novio.";
                return false;
            }
            if (String.IsNullOrEmpty(slueNovia.EditValue.ToString().Trim()))
            {
                slueNovia.ErrorText = "Seleccione la novia.";
                return false;
            }

            if (String.IsNullOrEmpty(deFecha.EditValue.ToString().Trim()))
            {
                deFecha.ErrorText = "Seleccione la fecha del sacramento.";
                return false;
            }

            if (lueLugar.EditValue == null)
            {
                lueLugar.ErrorText = "Seleccione el lugar.";
                return false;
            }

            if (String.IsNullOrEmpty(slueEmpleado.EditValue.ToString().Trim()))
            {
                slueEmpleado.ErrorText = "Seleccione el sacerdote.";
                return false;
            }

            if (String.IsNullOrEmpty(sluePadrinoNovio.EditValue.ToString().Trim()))
            {
                sluePadrinoNovio.ErrorText = "Seleccione el padrino del novio.";
                return false;
            }
            if (String.IsNullOrEmpty(slueMadrinaNovio.EditValue.ToString().Trim()))
            {
                slueMadrinaNovio.ErrorText = "Seleccione la madrina del novio.";
                return false;
            }

            if (String.IsNullOrEmpty(sluePadrinoNovia.EditValue.ToString().Trim()))
            {
                sluePadrinoNovia.ErrorText = "Seleccione el padrino del novia.";
                return false;
            }
            if (String.IsNullOrEmpty(slueMadrinaNovia.EditValue.ToString().Trim()))
            {
                slueMadrinaNovia.ErrorText = "Seleccione la madrina del novia.";
                return false;
            }

            if (sluePadrinoNovio.EditValue.Equals(slueNovio.EditValue))
            {
                sluePadrinoNovio.ErrorText = "El padrino no puede ser el mismo novio";
                sluePadrinoNovio.Focus();
                return false;
            }

            if (sluePadrinoNovia.EditValue.Equals(slueNovio.EditValue))
            {
                sluePadrinoNovia.ErrorText = "El padrino no puede ser el mismo novio";
                sluePadrinoNovia.Focus();
                return false;
            }

            if (sluePadrinoNovio.EditValue.Equals(sluePadrinoNovia.EditValue))
            {
                sluePadrinoNovio.ErrorText = "No puede ser padrino de ambos";
                sluePadrinoNovio.Focus();
                return false;
            }

            if (slueMadrinaNovio.EditValue.Equals(slueMadrinaNovia.EditValue))
            {
                slueMadrinaNovio.ErrorText = "No puede ser padrino de ambos";
                slueMadrinaNovio.Focus();
                return false;
            }

            if (slueMadrinaNovio.EditValue.Equals(slueNovia.EditValue))
            {
                slueMadrinaNovio.ErrorText = "La madrina no puede ser la misma novia.";
                slueMadrinaNovio.Focus();
                return false;
            }

            if (slueMadrinaNovia.EditValue.Equals(slueNovia.EditValue))
            {
                slueMadrinaNovia.ErrorText = "La madrina no puede ser la misma novia.";
                slueMadrinaNovia.Focus();
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
        private void Limpiar()
        {
            slueNovio.EditValue = "";
            slueNovia.EditValue = "";
            deFecha.EditValue = "";
            lueLugar.EditValue = null;
            slueEmpleado.EditValue = "";
            sluePadrinoNovio.EditValue = "";
            slueMadrinaNovio.EditValue = "";
            sluePadrinoNovia.EditValue = "";
            slueMadrinaNovia.EditValue = "";
            txtNumLibro.EditValue = "";
            txtNumPagina.EditValue = "";
            txtNumActa.EditValue = "";
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
        private void MostrarDatosMatrinmonio(int id)
        {
            CNFeligres objfeligres = new CNFeligres();
            CNSacramento objObtenerSacramento = new CNSacramento();
            CESacramento objSacramento = objObtenerSacramento.ObtenerSacramento(id);
            List<CEPadrinoPorFeligres> objPadrinos = objObtenerSacramento.ObtenerPadrinosFeligres(id);
            List<CESacramentoPorFeligres> objNovios = objObtenerSacramento.SeleccionarNoviosMatrimonio(id); 
            CESacramentoPorFeligres objFeligres = objObtenerSacramento.ObtenerFeligresSacramento(id);
            CEPadrinoPorFeligres objPadrinoH = new CEPadrinoPorFeligres();
            CEPadrinoPorFeligres objMadrinaH = new CEPadrinoPorFeligres();
            CEPadrinoPorFeligres objPadrinoM = new CEPadrinoPorFeligres();
            CEPadrinoPorFeligres objMadrinaM = new CEPadrinoPorFeligres();
            txtIdRegistro.EditValue = objSacramento.Id_Registro_Sacramento;
            deFecha.EditValue = objSacramento.Fecha;
            slueEmpleado.EditValue = objSacramento.Num_Identidad.ToString().Trim();
            lueLugar.EditValue = objSacramento.Id_Lugar;
            txtNumLibro.EditValue = objSacramento.Numero_Libro;
            txtNumPagina.EditValue = objSacramento.Numero_Pagina;
            txtNumActa.EditValue = objSacramento.Numero_Acta;

            slueNovio.EditValue = objNovios[0].Feligres_Num_Identidad.ToString();
            slueNovia.EditValue = objNovios[1].Feligres_Num_Identidad.ToString();

            foreach (CEPadrinoPorFeligres padrino in objPadrinos)
            {
                if (padrino.De_Novio)
                {
                    if(objfeligres.ObtenerFeligres(padrino.Feligres_Num_Identidad).IdSexo == 1)
                    {
                        objMadrinaH = padrino;
                    }
                    else
                    {
                        objPadrinoH = padrino;
                    }
                }
                else
                {
                    if (objfeligres.ObtenerFeligres(padrino.Feligres_Num_Identidad).IdSexo == 1)
                    {
                        objMadrinaM = padrino;
                    }
                    else
                    {
                        objPadrinoM = padrino;
                    }
                }
            }

            slueMadrinaNovio.EditValue = objMadrinaH.Feligres_Num_Identidad;
            sluePadrinoNovio.EditValue = objPadrinoH.Feligres_Num_Identidad;
            slueMadrinaNovia.EditValue = objMadrinaM.Feligres_Num_Identidad;
            sluePadrinoNovia.EditValue = objPadrinoM.Feligres_Num_Identidad;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(true, false, false, false, false);
            this.Close();
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
                    Id_Sacramento = int.Parse(idSacramento.ToString()),
                    Fecha = deFecha.DateTime.Date,
                    Num_Identidad = slueEmpleado.EditValue.ToString(),
                    Id_Lugar = int.Parse(lueLugar.EditValue.ToString()),
                    Numero_Libro = int.Parse(txtNumLibro.EditValue.ToString()),
                    Numero_Pagina = int.Parse(txtNumPagina.EditValue.ToString()),
                    Numero_Acta = int.Parse(txtNumActa.EditValue.ToString()),
                    Id_Usuario = 6
                };

                idRegistro = int.Parse(txtIdRegistro.EditValue.ToString());

                CEPadrinoPorFeligres objPadrinoNovio = new CEPadrinoPorFeligres()
                {
                    Id_Registro_Sacramento = idRegistro,
                    Feligres_Num_Identidad = sluePadrinoNovio.EditValue.ToString()
                };

                CEPadrinoPorFeligres objMadrinaNovio = new CEPadrinoPorFeligres()
                {
                    Id_Registro_Sacramento = idRegistro,
                    Feligres_Num_Identidad = slueMadrinaNovio.EditValue.ToString(),
                    De_Novio = true
                };
                CEPadrinoPorFeligres objPadrinoNovia = new CEPadrinoPorFeligres()
                {
                    Id_Registro_Sacramento = idRegistro,
                    Feligres_Num_Identidad = sluePadrinoNovia.EditValue.ToString()
                };

                CEPadrinoPorFeligres objMadrinaNovia = new CEPadrinoPorFeligres()
                {
                    Id_Registro_Sacramento = idRegistro,
                    Feligres_Num_Identidad = slueMadrinaNovia.EditValue.ToString()
                };

                if (objActualizarRegistro.ActualizarRegistroSacramento(objSacramento) > 0)
                {
                    if (objPadrinoNovio.Feligres_Num_Identidad != "")
                    {
                        objActualizarRegistro.ActualizarPadrinosPorFeligres(objPadrinoNovio, padrinoAnteriorH);
                    }

                    if (objMadrinaNovio.Feligres_Num_Identidad != "")
                    {
                        objActualizarRegistro.ActualizarPadrinosPorFeligres(objMadrinaNovio, madrinaAnteriorH);
                    }

                    if (objPadrinoNovia.Feligres_Num_Identidad != "")
                    {
                        objActualizarRegistro.ActualizarPadrinosPorFeligres(objPadrinoNovia, padrinoAnteriorM);
                    }

                    if (objMadrinaNovia.Feligres_Num_Identidad != "")
                    {
                        objActualizarRegistro.ActualizarPadrinosPorFeligres(objMadrinaNovia, madrinaAnteriorM);
                    }

                    XtraMessageBox.Show("Registro actualizado satisfactoriamente.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    HabilitarControles(true, false, false, false, false);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar el registro.", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void txtNumLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void txtNumPagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void txtNumActa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
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

        private void slueNovio_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = slueNovio.Properties.NullText;
                slueNovio.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = slueNovio.Properties.NullText;
                slueNovio.EditValue = "";
            }
        }

        private void slueNovia_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
            {
                e.DisplayText = slueNovia.Properties.NullText;
                slueNovia.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = slueNovia.Properties.NullText;
                slueNovia.EditValue = "";
            }
        }

        private void sluePadrinoNovio_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = sluePadrinoNovio.Properties.NullText;
                sluePadrinoNovio.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = sluePadrinoNovio.Properties.NullText;
                sluePadrinoNovio.EditValue = "";
            }
        }

        private void slueMadrinaNovio_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = slueMadrinaNovio.Properties.NullText;
                slueMadrinaNovio.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = slueMadrinaNovio.Properties.NullText;
                slueMadrinaNovio.EditValue = "";
            }
        }

        private void sluePadrinoNovia_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = sluePadrinoNovia.Properties.NullText;
                sluePadrinoNovia.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = sluePadrinoNovia.Properties.NullText;
                sluePadrinoNovia.EditValue = "";
            }
        }

        private void slueMadrinaNovia_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = slueMadrinaNovia.Properties.NullText;
                slueMadrinaNovia.EditValue = "";
            }
            else if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.DisplayText = slueMadrinaNovia.Properties.NullText;
                slueMadrinaNovia.EditValue = "";
            }
        }
    }  
}