using Be;
using Bll;
using ServicioClase;
using Servicios;
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
    public partial class GUsuarios : Form
    {
        List<BelUsuario> lUsuario;
        BllUsuario bUsuario;
        PerfilManager Pm;
        //string txtdni;
        //string txtnombre;
        //string txtapellido;
        //string txtusuario;
        //string txtcontraseña;

        public GUsuarios()
        {
            InitializeComponent();
        }

        private void GUsuarios_Load(object sender, EventArgs e)
        {
            Pm = new PerfilManager();
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
                if (CargarTxt())
                {
                    throw new Exception("Error al cargar datos");
                }
                else
                {
                    Perfil _Perfil = Pm.ConsultaPerfil().Find(x => x.Nombre == "");
                    bUsuario.Alta(new BelUsuario(txtDni.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, _Perfil, txtUsuario.Text, /*Encriptar.EncriptarC(*/txtContraseña.Text));
                    lUsuario = bUsuario.Consulta();
                    throw new Exception("Usuario creado");
                    
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
