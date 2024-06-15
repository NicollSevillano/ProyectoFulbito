using Be;
using Bll;
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
    public partial class GReservas : Form
    {
        List<BeCliente> lCliente;
        BeCliente bCliente;
        BllCliente blCliente;
        public GReservas()
        {
            InitializeComponent();
        }

        private void GReservas_Load(object sender, EventArgs e)
        {
            lCliente = new List<BeCliente>();
            bCliente = new BeCliente();
            blCliente = new BllCliente();
        }
        private bool CargarCliente()
        {
            bool txtValido = false;
            if (txtDni.Text == string.Empty|| txtNombre.Text == string.Empty)
            {
                txtValido = true;
            }
            return txtValido;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CargarCliente())
                {
                    blCliente.Consulta().Find(x => x.DNI == txtDni.Text);
                    bCliente = new BeCliente(txtDni.Text, txtNombre.Text, null);
                    blCliente.Alta(bCliente);

                    lCliente = blCliente.Consulta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Refresercar()
        {

        }
    }
}
