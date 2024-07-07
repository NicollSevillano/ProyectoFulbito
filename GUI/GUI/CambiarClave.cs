﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be;
using Bll;
using Interface;
using ServicioClase;
using Servicios;

namespace GUI
{
    public partial class CambiarClaveForm : Form, ITraducible
    {
        public CambiarClaveForm()
        {
            InitializeComponent();
        }
        BllUsuario bllUsuario;
        GUsuariosForm cClave;
        private bool mostrar = false;
        public BelUsuario beUsuario { get; set; } 

        private void CambiarClave_Load(object sender, EventArgs e)
        {
            bllUsuario = new BllUsuario();
            cClave = new GUsuariosForm();
        }
        private bool AgregarTxt()
        {
            bool txtconfirmar = false;
            if(txtContraseñaC.ToString() == string.Empty || txtContraseñaN.ToString() == string.Empty)
            {
                txtconfirmar = true;
            }
            return txtconfirmar;
        }

        private void btnCambiarC_Click(object sender, EventArgs e)
        {
            if (!AgregarTxt())
            {
                //confirmar contraseña
                if(txtContraseñaC.Text == txtContraseñaN.Text)
                {
                    beUsuario.Contraseña = Encriptar.Encrypt(txtContraseñaN.Text);
                    bllUsuario.Modificacion(beUsuario);
                    MessageBox.Show("Contraseña cambiada");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            labCC.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labCC").Texto;
            labContraseñaN.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labContraseñaN").Texto;
            labConfirmarC.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labConfirmarC").Texto;
            btnCambiarC.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCambiarC").Texto;
            btnSalir.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalir").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalir").Texto;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mostrar = !mostrar;
            if (mostrar)
            {
                txtContraseñaC.PasswordChar = '\0';
                pictureBox2.Image = GUI.Properties.Resources.oculto;
            }
            else
            {
                txtContraseñaC.PasswordChar = '*';
                pictureBox2.Image = GUI.Properties.Resources.ver;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mostrar = !mostrar;
            if (mostrar)
            {
                txtContraseñaN.PasswordChar = '\0';
                pictureBox3.Image = GUI.Properties.Resources.oculto;
            }
            else
            {
                txtContraseñaN.PasswordChar = '*';
                pictureBox3.Image = GUI.Properties.Resources.ver;
            }
        }
    }
}
