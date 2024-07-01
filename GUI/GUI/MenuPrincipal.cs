using Be;
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
    public partial class MenuPrincipalForm : Form
    {
        public SessionManager smanager;
        GRegistrarClienteForm registrarCliente;
        GReservasForm reservas;
        GUsuariosForm usuarios;

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
            labUsuarioMp.Text = smanager.usuario.Nombre;
            labPerfilMp.Text = smanager.usuario.Perfil.Nombre;
        }
        private void habilitarControles()
        {
            List<Permiso> lPermiso = new List<Permiso>();
            (SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto).RellenaArrayPermisos(SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto, lPermiso);
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
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

        //private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //}

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
            usuarios.ShowDialog();
            this.Show();
        }
        private void controlDeCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //cancha.ShowDialog();
            this.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SessionManager.LogOut();
            this.Close();
        }
    }
}
