using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controles;
using Be;
using Bll;
using ServicioClase;
using Servicios; 

namespace GUI
{
    public partial class LogIn : Form
    {
        List<BelUsuario> lUsuario;
        BllUsuario bUsuario;

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            bUsuario = new BllUsuario();
            //lUsuario = bUsuario.Consulta();
            //foreach (BelUsuario usuario in lUsuario)
            //{
            //    usuario.Contraseña = Encriptar.EncriptarC(usuario.Contraseña);
            //    bUsuario.Modificacion(usuario);
            //}
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lUsuario = bUsuario.Consulta();
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            try
            {
                BelUsuario _usuario = lUsuario.Find(x => x.Usuario == usuario);
                if (_usuario == null) throw new Exception("Usuario no encontrado");
                if (_usuario.Bloqueado) throw new Exception("Usuario bloqueado");
                if (_usuario.Intentos < 3)
                {
                    _usuario.Bloqueado = true;
                    bUsuario.Modificacion(_usuario);
                }
                _usuario.Intentos++;
                bUsuario.Modificacion(_usuario);
                if (!Encriptar.Compare(contraseña, _usuario.Contraseña)) throw new Exception("Contraseña incorrecta");
                SessionManager.LogIn(_usuario);
                MenuPrincipal menu = new MenuPrincipal();
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
