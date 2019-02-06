using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaNegocio;
using CapaEntidad;
namespace CapaPresentacion.Formularios
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static Boolean error = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
    
            if (!Properties.Settings.Default.Tema.Trim().Equals(""))
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Properties.Settings.Default.Tema.Trim();
            }

         
        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtUsuario.EditValue.ToString().Trim()))
            {
                txtUsuario.ErrorText = "Ingrese el nombre de usuario";
                return false;
            }
            if (String.IsNullOrEmpty(txtContrasena.EditValue.ToString().Trim()))
            {
                txtContrasena.ErrorText = "Ingrese la contraseña";
                return false;
            }
           
            return true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNLogin objIniciarSesion = new CNLogin();
                CELogin objLogin = new CELogin()
                {
                    Usuario = txtUsuario.Text.Trim().Replace("'", ""),
                    Contrasena = Funciones.Funciones.Hash((txtContrasena.Text.Trim().Replace("'", "")))
                };

                if (objIniciarSesion.IniciarSesion(objLogin) > 0)
                {
                    this.Hide();
                    Funciones.Funciones.idUsuario = objIniciarSesion.IniciarSesion(objLogin);
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.txtUsuario.Caption = txtUsuario.Text.ToString().ToUpper();
                    frm.Show();
                    error = false;
                }
                else if(objIniciarSesion.IniciarSesion(objLogin) == -1)
                {
                    FrmConfiguracion frm = new FrmConfiguracion();
                    frm.Show();
                    error = true;
                    Close();
                }
                else
                {
                    error = false;
                    XtraMessageBox.Show("Usuario o contraseña incorrecto", "Parroquia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnIniciar.PerformClick();
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar.PerformClick();
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}