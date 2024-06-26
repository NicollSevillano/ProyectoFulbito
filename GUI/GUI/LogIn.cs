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
    public partial class InicioSesionForm : Form
    {
        List<BelUsuario> lUsuario;
        BllUsuario bUsuario;
        private bool mostrar = false;

        public InicioSesionForm()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            bUsuario = new BllUsuario();
            lUsuario = bUsuario.Consulta();
            //foreach (BelUsuario usuario in lUsuario)
            //{
            //    string hashedPassword = Encriptar.Encrypt(usuario.Contraseña);
            //    usuario.Contraseña = hashedPassword;
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
                if (lUsuario.Exists(x => x.Usuario == usuario))
                {
                    BelUsuario _usuario = lUsuario.Find(x => x.Usuario == usuario);

                    if (_usuario.Intentos >= 3)
                    {
                        _usuario.Bloqueado = true;
                        _usuario.Intentos = 0;
                        bUsuario.Modificacion(_usuario);
                        throw new Exception("Usuario bloqueado");
                    }
                    string aux = Encriptar.Encrypt(contraseña);
                    if (aux != _usuario.Contraseña)
                    {
                        _usuario.Intentos++;
                        bUsuario.Modificacion(_usuario);
                        throw new Exception("Contraseña incorrecta");
                    }

                    if (_usuario.Perfil.Nombre == "Administrador")
                    {
                        MenuPrincipalForm mp = new MenuPrincipalForm();
                        SessionManager.LogIn(_usuario);
                        mp.smanager = SessionManager.getInstance;
                        _usuario.Intentos = 0;
                        bUsuario.Modificacion(_usuario);
                        this.Hide();
                        mp.ShowDialog();
                        this.Show();
                    }
                    else if(_usuario.Perfil.Nombre == "Empleado")
                    {
                        GReservasForm gr = new GReservasForm();
                        SessionManager.LogIn(_usuario);
                        gr.smanager = SessionManager.getInstance;
                        _usuario.Intentos = 0;
                        bUsuario.Modificacion(_usuario);
                        this.Hide();
                        gr.ShowDialog();
                        this.Show();
                    }

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
