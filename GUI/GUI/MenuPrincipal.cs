using Be;
using Interface;
using ServicioClase;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuPrincipalForm : Form, ITraducible
    {
        public SessionManager smanager;
        GRegistrarClienteForm registrarCliente;
        GReservasForm reservas;
        GUsuariosForm usuarios;
        CobrarReservaForm cobrar;
        CambiarClaveForm cambiarClave;
        PerfilesForm perfiles;
        Tarjeta tarjeta;

        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            habilitarControles();
            reservas = new GReservasForm();
            registrarCliente = new GRegistrarClienteForm();
            usuarios = new GUsuariosForm();
            cobrar = new CobrarReservaForm();
            cambiarClave = new CambiarClaveForm();
            //perfiles = new PerfilesForm();
            tarjeta = new Tarjeta();
            LanguageManager.Suscribir(reservas);
            LanguageManager.Suscribir(registrarCliente);
            LanguageManager.Suscribir(usuarios);
            LanguageManager.Suscribir(cobrar);
            LanguageManager.Suscribir(cambiarClave);
            LanguageManager.Suscribir(tarjeta);
            labUsuarioMp.Text = smanager.usuario.Nombre;
            labPerfilMp.Text = smanager.usuario.Perfil.Nombre;
            //comboIdioma1.retornacmBox().SelectedIndex = int.Parse(SessionManager.getInstance.usuario.id) - 1;
        }
        private void habilitarControles()
        {
            List<Permiso> lPermiso = new List<Permiso>();
            (SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto).RellenaArrayPermisos(SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto, lPermiso);
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                if (menu.Name != null)
                {
                    menu.Visible = false;
                    foreach (Permiso permiso in lPermiso)
                    {
                        if (menu.Name.ToString() == permiso.Nombre)
                        {
                            menu.Visible = true;
                        }
                    }
                }
                foreach (ToolStripMenuItem item in menu.DropDownItems)
                {
                    if (item.Name != null)
                    {
                        item.Visible = false;
                        foreach (Permiso permiso in lPermiso)
                        {
                            if(item.Name.ToString() == permiso.Nombre)
                            {
                                item.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrarCliente.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservas.ShowDialog();
            this.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuarios.ShowDialog();
            this.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SessionManager.LogOut();
            this.Close();
        }
        //verificar
        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            labNombreMp.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labNombreMp").Texto;
            labRolMp.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labRolMp").Texto;
            reservaToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "reservaToolStripMenuItem").Texto;
            clientesToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "clientesToolStripMenuItem").Texto;
            registrarClienteToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "registrarClienteToolStripMenuItem").Texto;
            usuariosToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "usuariosToolStripMenuItem").Texto;
            idiomasToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "idiomasToolStripMenuItem").Texto;
            inventarioToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "inventarioToolStripMenuItem").Texto;
            ayudaToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "ayudaToolStripMenuItem").Texto;
            btnSalirm.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalirm").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "MenuPrincipalForm").Texto;
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cobrar.ShowDialog();
            this.Show();
        }

        private void btnSalirm_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();
        }
    }
}
