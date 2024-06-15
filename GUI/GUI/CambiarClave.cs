using System;
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
using Servicios;

namespace GUI
{
    public partial class CambiarClave : Form
    {
        public CambiarClave()
        {
            InitializeComponent();
        }
        BllUsuario bllUsuario;
        GUsuarios cClave;
        public BelUsuario beUsuario { get; set; } 

        private void CambiarClave_Load(object sender, EventArgs e)
        {
            bllUsuario = new BllUsuario();
            cClave = new GUsuarios();
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
    }
}
