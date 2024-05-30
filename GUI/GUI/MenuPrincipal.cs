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
    public partial class MenuPrincipal : Form
    {
        GReservas reservas;
        GCancha cancha;
        GRegistrarCliente registrarCliente;
        GUsuarios usuarios;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            reservas = new GReservas();
            cancha = new GCancha();
            registrarCliente = new GRegistrarCliente();
            usuarios = new GUsuarios();
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
            cancha.ShowDialog();
            this.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuarios.ShowDialog();
            this.Show();
        }
    }
}
