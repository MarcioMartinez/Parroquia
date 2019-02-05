using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
           
        

            lblConnStatus.Text = "Conexión almacenada con exito";
            Properties.Settings.Default.Reload();
            
            String cadena = Properties.Settings.Default.cn2.ToString();

            String[] c = cadena.Split(';');
            

            txtServer.Text = c[0].Replace( "Data Source=", "");
            txtDB.Text = c[1].Replace("Initial Catalog=", "");
            String n = c[2].Replace("User ID=", "");
            txtUsername.Text = n.Replace(" ", "");
            txtPassword.Text = c[3].Replace("Password=", ""); 
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            lblConnStatus.Text = "Comprobando conexión...";
            try
            {
                string nuevaCadenaConexion = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDB.Text + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text + "";
                SqlConnection cn = new SqlConnection(nuevaCadenaConexion);
                cn.Open();
                Properties.Settings.Default.cn2 = nuevaCadenaConexion;
                Properties.Settings.Default.Save();
                lblConnStatus.Text = "Conexión almacenada con exito";

                if (FrmLogin.error)
                {
                    FrmLogin.error = false;
                    FrmLogin frm = new FrmLogin();
                    frm.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblConnStatus.Text = "Error de Conexión";
            }
          
        }

        private void txtServer_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
