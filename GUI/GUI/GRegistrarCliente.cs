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
    public partial class GRegistrarCliente : Form
    {
        List<BeCliente> lCliente;
        BllCliente blCliente;
        GReservas reservas;

        public GRegistrarCliente()
        {
            InitializeComponent();
        }

        private void GRegistrarCliente_Load(object sender, EventArgs e)
        {
            blCliente = new BllCliente();
            reservas = new GReservas();
            lCliente = blCliente.Consulta();
            Refrescar();
        }
        private bool Cargartxt()
        {
            bool txtValidado = false;
            if (txtDni.ToString() == string.Empty ||
                txtNombre.ToString() == string.Empty ||
                txtTelefono.ToString() == string.Empty)
            {
                txtValidado = true;
            }
            return txtValidado;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Cargartxt())
                {
                    BeCliente nuevoCliente;
                    nuevoCliente = new BeCliente(txtDni.Text, txtNombre.Text, txtTelefono.Text);
                    blCliente.Alta(nuevoCliente);
                    lCliente = blCliente.Consulta();
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow d in dgvCliente.SelectedRows)
                {
                    int id = Convert.ToInt32(d.Cells[0].Value);
                    blCliente.Baja(id);
                    lCliente = blCliente.Consulta();
                }
                MessageBox.Show("Usuario eliminado"); 
            }
            Refrescar();
        }
        private void Refrescar()
        {
            dgvCliente.Rows.Clear();
            foreach (BeCliente item in lCliente)
            {
                dgvCliente.Rows.Add(item.id, item.DNI, item.Nombre, item.Telefono);
            }
        }
        private void Filtar()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridViewRow row = dgvCliente.SelectedRows[0];
                //txtDni.Text = row.Cells[1].Value.ToString();
                //txtNombre.Text = row.Cells[2].Value.ToString();
                //txtTelefono.Text = row.Cells[3].Value.ToString();
            }
            catch 
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvCliente.Rows.Count > 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DataGridViewRow dgr = dgvCliente.SelectedRows[0];
                string cliente = dgr.Cells[0].Value.ToString();

                BeCliente clienteModificar = lCliente.Find(x => x.id == cliente);

                if (!Cargartxt())
                {
                    clienteModificar.DNI = txtDni.Text;
                    clienteModificar.Nombre = txtNombre.Text;
                    clienteModificar.Telefono = txtTelefono.Text;

                    blCliente.Modificacion(clienteModificar);
                    lCliente = blCliente.Consulta();
                    Refrescar();
                    MessageBox.Show("Usuario modificado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
