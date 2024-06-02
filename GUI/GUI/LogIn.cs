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
using Mapper;
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI
{
    public partial class LogIn : Form
    {
        List<BelUsuario> lUsuario;
        BllUsuario bUsuario;
        private bool mostrar = false;

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

            bUsuario = new BllUsuario();
            lUsuario = bUsuario.Consulta();

            foreach (BelUsuario usuario in lUsuario)
            {
                string hashedPassword = Encriptar.HashPassword(usuario.Contraseña);
                if (hashedPassword.Length > 20)
                {
                    hashedPassword = hashedPassword.Substring(1, 20);
                }
                usuario.Contraseña = hashedPassword;
                bUsuario.Modificacion(usuario);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lUsuario = bUsuario.Consulta();
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            try
            {
                if (lUsuario.Exists(x => x.Usuario == usuario))
                {
                    BelUsuario _usuario = lUsuario.Find(x => x.Usuario == usuario);
                    if (_usuario == null) throw new Exception("Usuario no encontrado");

                    if (_usuario.Perfil.Nombre == "Administrador")
                    {
                        MenuPrincipal mp = new MenuPrincipal();
                        SessionManager.LogIn(_usuario);
                        mp.smanager = SessionManager.getInstance;
                        this.Hide();
                        mp.ShowDialog();
                        this.Show();
                    }
                    else if(_usuario.Perfil.Nombre == "Empleado")
                    {
                        GReservas gr = new GReservas();
                        SessionManager.LogIn(_usuario);
                        gr.smanager = SessionManager.getInstance;
                        this.Hide();
                        gr.ShowDialog();
                        this.Show();
                    }

                    if (_usuario.Intentos >= 3)
                    {
                        _usuario.Bloqueado = true;
                        throw new Exception("Usuario bloqueado");
                    }

                    if (!Encriptar.VerifyPassword(contraseña, _usuario.Contraseña))
                    {
                        _usuario.Intentos++;
                        bUsuario.Modificacion(_usuario);
                        throw new Exception("Contraseña incorrecta");
                    }

                    _usuario.Intentos = 0;
                    bUsuario.Modificacion(_usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pMostrar_Click(object sender, EventArgs e)
        {
            mostrar = !mostrar;
            if (mostrar)
            {
                txtContraseña.PasswordChar = '\0';
                pMostrar.Image = GUI.Properties.Resources.oculto;
            }
            else
            {
                txtContraseña.PasswordChar = '*';
                pMostrar.Image = GUI.Properties.Resources.ver;
            }
        }
    }
}
