using Be;
using Bll;
using Mapper;
using ServicioClase;
using Servicios;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class GUsuarios : Form
    {
        List<BelUsuario> lUsuario;
        BllUsuario bllUsuario;
        BelUsuario beUsuario;
        CambiarClave cambiarClave;

        public GUsuarios()
        {
            InitializeComponent();
        }

        private void GUsuarios_Load(object sender, EventArgs e)
        {
            bllUsuario = new BllUsuario();
            lUsuario = bllUsuario.Consulta();
            RefrescarDgv();
            cambiarClave = new CambiarClave();
        }
        private bool CargarTxt()
        {
            bool txtValidad = false;
            if (txtDni.Text == string.Empty ||
                txtNombre.Text == string.Empty ||
                txtApellido.Text == string.Empty ||
                txtEmail.Text == string.Empty ||
                txtUsuario.Text == string.Empty ||
                txtContraseña.Text == string.Empty)
            {
                txtValidad = true;
            }
            return txtValidad;

        }
        Perfil perfil;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CargarTxt())
                {
                    BelUsuario nuevoUsuario;
                    if (rbAdministrador.Checked == true)
                    {
                        perfil = PerfilManager.ConsultaPerfil().Find(x => x.Nombre == "Administrador");
                        nuevoUsuario = new BelUsuario(txtDni.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, perfil, txtUsuario.Text, Encriptar.Encrypt(txtContraseña.Text));
                        bllUsuario.Alta(nuevoUsuario);
                    }
                    else if(rbEmpleado.Checked == true)
                    {
                        perfil = PerfilManager.ConsultaPerfil().Find(x => x.Nombre == "Empleado");
                        nuevoUsuario = new BelUsuario(txtDni.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, perfil, txtUsuario.Text, Encriptar.Encrypt(txtContraseña.Text));
                        bllUsuario.Alta(nuevoUsuario);
                    }
                    
                    lUsuario = bllUsuario.Consulta();
                    RefrescarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsuarios.SelectedRows)
                {
                    int userId = Convert.ToInt32(row.Cells[0].Value);
                    bllUsuario.Baja(userId);
                    lUsuario = bllUsuario.Consulta();
                }
                MessageBox.Show("Usuario eliminado");
            }
            RefrescarDgv();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                string usuarioId = row.Cells[0].Value.ToString();

                BelUsuario usuarioAModificar = lUsuario.Find(u => u.id == usuarioId);

                if (!CargarTxt())
                {
                    usuarioAModificar.DNI = txtDni.Text;
                    usuarioAModificar.Nombre = txtNombre.Text;
                    usuarioAModificar.Apellido = txtApellido.Text;
                    usuarioAModificar.Email = txtEmail.Text;
                    usuarioAModificar.Usuario = txtUsuario.Text;
                    if(txtContraseña.ReadOnly == false)
                    {
                        txtContraseña.ReadOnly = true;
                        MessageBox.Show("No se puede cambiar la contraseña del usuario desde este formulario");
                    }

                    if (rbAdministrador.Checked == true)
                    {
                        usuarioAModificar.Perfil = PerfilManager.ConsultaPerfil().Find(x => x.Nombre == "Administrador");
                        bllUsuario.Modificacion(usuarioAModificar);
                        lUsuario = bllUsuario.Consulta();
                        RefrescarDgv();
                        MessageBox.Show("Usuario modificado exitosamente");

                    }
                    else if (rbEmpleado.Checked == true)
                    {
                        usuarioAModificar.Perfil = PerfilManager.ConsultaPerfil().Find(x => x.Nombre == "Empleado");
                        bllUsuario.Modificacion(usuarioAModificar);
                        lUsuario = bllUsuario.Consulta();
                        RefrescarDgv();
                        MessageBox.Show("Usuario modificado exitosamente");
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            catch (Exception)
            {
                throw;
            }
        }
        private void FiltroDgv()
        {
            try
            {
                dgvUsuarios.Rows.Clear();
                foreach (BelUsuario b in lUsuario)
                {
                    dgvUsuarios.Rows.Add(new object[] { b.id, b.DNI, b.Nombre, b.Apellido, b.Email, b.Perfil.id, b.Usuario, b.Contraseña, b.Bloqueado, b.Activo });
                    if (b.Bloqueado)
                    {
                        dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (b.Activo == false)
                    {
                        dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.DarkRed;
                    }
                    else
                    {
                        dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefrescarDgv()
        {
            dgvUsuarios.Rows.Clear();
            foreach (BelUsuario item in lUsuario)
            {
                dgvUsuarios.Rows.Add(item.id, item.DNI, item.Nombre, item.Apellido, item.Email, item.Perfil.Nombre, item.Usuario, item.Contraseña, item.Bloqueado, item.Activo);
            }
            FiltroDgv();
        }
        private void cbBloqueados_TextChanged(object sender, EventArgs e)
        {
            List<BelUsuario> t = lUsuario;
            if (cbBloqueados.Checked) t = lUsuario.Where(x => x.Bloqueado == cbBloqueados.Checked).ToList<BelUsuario>();
        }
        private BelUsuario LlamarUsuario()
        {
            return lUsuario.Find(x => x.id == dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            BelUsuario x = LlamarUsuario();
            if (x.Bloqueado)
            {
                x.Bloqueado = false;
            }
            else
            {
                x.Bloqueado = true;
            }
            bllUsuario.Modificacion(x);
            lUsuario = bllUsuario.Consulta();
            RefrescarDgv();
        }
        private void btnActivar_Click(object sender, EventArgs e)
        {
            BelUsuario x = LlamarUsuario();
            if (x.Activo)
            {
                x.Activo = false;
            }
            else
            {
                x.Activo = true;
            }
            bllUsuario.Modificacion(x);
            lUsuario = bllUsuario.Consulta();
            RefrescarDgv();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();
        }
        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                txtDni.Text = row.Cells[1].Value.ToString();
                txtNombre.Text = row.Cells[2].Value.ToString();
                txtApellido.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtUsuario.Text = row.Cells[6].Value.ToString();
                txtContraseña.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void cbBloqueados_CheckedChanged(object sender, EventArgs e)
        {
            List<BelUsuario> t = lUsuario;
            t = lUsuario.Where(x => x.Bloqueado == cbBloqueados.Checked).ToList<BelUsuario>();
            lUsuario = t;
            RefrescarDgv();
        }
        private void btnCambiarC_Click(object sender, EventArgs e)
        {
            this.Hide();
            cambiarClave.beUsuario = LlamarUsuario();
            cambiarClave.ShowDialog();
            this.Show();
            lUsuario = bllUsuario.Consulta();
            RefrescarDgv();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            PerfilesForm perfil = new PerfilesForm(LlamarUsuario());
            perfil.ShowDialog();
            bllUsuario.Consulta();
            this.Show();
            
        }
    }
}
