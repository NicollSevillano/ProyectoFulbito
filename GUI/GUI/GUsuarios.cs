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

        public GUsuarios()
        {
            InitializeComponent();
        }

        private void GUsuarios_Load(object sender, EventArgs e)
        {
            lUsuario = new List<BelUsuario>();
            bllUsuario = new BllUsuario();
            RefrescarDgv();
            foreach (BelUsuario usuario in lUsuario)
            {
                string hashedPassword = Encriptar.HashPassword(usuario.Contraseña);
                if (hashedPassword.Length > 20)
                {
                    hashedPassword = hashedPassword.Substring(1, 20);
                }
                usuario.Contraseña = hashedPassword;
                bllUsuario.Modificacion(usuario);
            }
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CargarTxt())
                {
                    
                    Perfil perfil;

                    if (rbAdministrador.Checked)
                    {
                        perfil = PerfilManager.ConsultaPerfil().Find(x => x.Nombre == "Administrador");
                    }
                    else
                    {
                        perfil = PerfilManager.ConsultaPerfil().Find(x => x.Nombre == "Empleado");
                    }

                    BelUsuario nuevoUsuario = new BelUsuario(txtDni.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, perfil, txtUsuario.Text, txtContraseña.Text);
                    bllUsuario.Alta(nuevoUsuario);

                    lUsuario = bllUsuario.Consulta();
                    foreach (BelUsuario usuario in lUsuario)
                    {
                        dgvUsuarios.Rows.Add(usuario.id, usuario.Nombre, usuario.Apellido, usuario.Email, usuario.Perfil, usuario.Usuario, Encriptar.HashPassword(usuario.Contraseña));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BelUsuario usuarioSeleccionado = LlamarUsuario();
            if (usuarioSeleccionado != null)
            {
                bllUsuario.Baja(usuarioSeleccionado.id);
                RefrescarDgv();
                MessageBox.Show("Usuario eliminado");
            }
        }
        string txtdni;
        string txtnombre;
        string txtapellido;
        string txtusuario;
        string txtcontraseña;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //BelUsuario bUsuario = LlamarUsuario();
                //string _dni = Interaction.InputBox("Dni:", "Modificando...", bUsuario.DNI);
                //string _nombre = Interaction.InputBox("Nombre:", "Modificando...", bUsuario.Nombre);
                //string _apellido = Interaction.InputBox("Apellido:", "Modificando...", bUsuario.Apellido);
                //string _email = Interaction.InputBox("Email:", "Modificando", bUsuario.Email);
                //string _usuario = Interaction.InputBox("Usuario:", "Modificando...", bUsuario.Usuario);
                //string _contraseña = Interaction.InputBox("Contraseña", "Modificando", bUsuario.Contraseña);
                //bUsuario.DNI = _dni; bUsuario.Nombre = _nombre;
                //bUsuario.Apellido = _apellido; bUsuario.Email = _email;
                //bUsuario.Usuario = _usuario; bUsuario.Contraseña = _contraseña;

                //bllUsuario.Modificacion(bUsuario);
                //lUsuario = bllUsuario.Consulta();
                //RefrescarDgv
            }

            catch (Exception)
            {

                throw;
            }
        }
        private void FiltroDgv(List<BelUsuario> dgv)
        {
            try
            {
                dgvUsuarios.Rows.Clear();
                foreach (BelUsuario b in dgv)
                {
                    dgvUsuarios.Rows.Add(new object[] { b.id, b.Nombre, b.Apellido, b.Email, b.Perfil.id, b.Usuario, b.Contraseña });
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
            List<BelUsuario> usuarios = bllUsuario.Consulta();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = bllUsuario.Consulta();
            foreach (BelUsuario usuario in lUsuario)
            {
                dgvUsuarios.Rows.Add(usuario.id, usuario.DNI, usuario.Nombre, usuario.Apellido, usuario.Email, usuario.Perfil.Nombre, usuario.Usuario, usuario.Contraseña, usuario.Bloqueado, usuario.Activo, usuario.Intentos);
            }
        }
        private void filtrarEstadoB(object sender, EventArgs e)
        {
            List<BelUsuario> t = lUsuario;
            if (cbBloqueados.Checked) t = lUsuario.Where(x => x.Bloqueado == cbBloqueados.Checked).ToList<BelUsuario>();
            FiltroDgv(t);
        }
        private void cbBloqueados_TextChanged(object sender, EventArgs e)
        {
            filtrarEstadoB(null, null);
        }
        //private BelUsuario LlamarUsuario()
        //{
        //    //return lUsuario.Find(x => x.id == dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
        //    if (dgvUsuarios.SelectedRows.Count > 0)
        //    {
        //        string id = dgvUsuarios.Rows[0].Cells[0].Value.ToString();
        //        return lUsuario.Find(u => u.id == id);
        //    }
        //    return null;
        //}
        private BelUsuario LlamarUsuario()
        {
            return lUsuario.Find(x => x.id == dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void filtrarEstadoA(object sender, EventArgs e)
        {
            List<BelUsuario> t = lUsuario;
            if (cbBloqueados.Checked) t = lUsuario.Where(x => x.Activo == cbActivos.Checked).ToList<BelUsuario>();
            FiltroDgv(t);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            filtrarEstadoA(null, null);
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
        //private void Habilitar()
        //{
        //    if (dgvUsuarios.SelectedRows.Count > 0)
        //    {
        //        btnDesbloquear.Enabled = LlamarUsuario().Bloqueado;
        //    }
        //    else
        //    {
        //        btnDesbloquear.Enabled = false;
        //    }
        //}

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            //Habilitar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();
        }

        private void rbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            //if(rbAdministrador.Checked == true)
            //{
            //    beUsuario.Perfil.Nombre = "Administrador";
            //}
        }
    }
}
