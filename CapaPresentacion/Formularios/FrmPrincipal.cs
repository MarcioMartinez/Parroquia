using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress;
using DevExpress.XtraBars.Helpers;
using CapaEntidad;
using CapaNegocio;
using System.IO;

namespace CapaPresentacion.Formularios
{
    public partial class FrmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true);

            if (!Properties.Settings.Default.Tema.Trim().Equals(""))
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Properties.Settings.Default.Tema.Trim();
            }

            CargarDatosGenerales();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
        private void CargarDatosGenerales()
        {
            CNDatosGenerales objDatos = new CNDatosGenerales();
            CEDatosGenerales objDatosG = new CEDatosGenerales();

            objDatosG = objDatos.Mostrar_Datos();

            lblNombreParroquia.Text = "Parroquia " + objDatosG.Nombre_Parroquia;
            Funciones.Funciones.nombreParroquia = "Parroquia " + objDatosG.Nombre_Parroquia;
            this.Text = objDatosG.Nombre_Parroquia;

            MemoryStream ms = new MemoryStream((byte[])objDatosG.Logo);
            pELogo.Image = Image.FromStream(ms);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
    
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            FrmGestionFeligres frm = new FrmGestionFeligres();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
    
            FrmGestionEmpleado frm = new FrmGestionEmpleado();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FrmGestionLugar frm = new FrmGestionLugar();
            frm.ShowDialog();
            frm.Focus();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmInfo frm = new FrmInfo();
            frm.ShowDialog();
            frm.Focus();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
 
            FrmGestionCargo frm = new FrmGestionCargo();
            frm.ShowDialog();
            frm.Focus();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDatosGenerales frm = new FrmDatosGenerales();
            frm.ShowDialog();
            frm.Focus();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGestionSacramentos frm = new FrmGestionSacramentos();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if(xtraTabbedMdiManager1.Pages.Count > 0)
            {
                pcLogo.Visible = false;
            }
            else
            {
                pcLogo.Visible = true;
            }
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (xtraTabbedMdiManager1.Pages.Count > 0)
            {
                pcLogo.Visible = false;
            }
            else
            {
                pcLogo.Visible = true;
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGestionUsuario frm = new FrmGestionUsuario();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            CargarDatosGenerales();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hide();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }
    }
}