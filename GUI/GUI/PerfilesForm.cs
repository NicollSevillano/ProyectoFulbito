using Be;
using Bll;
using Interface;
using Servicios;
using ServicioClase;
using System;
using System.Collections.Generic;
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
    public partial class PerfilesForm : Form, ITraducible
    {
        BelUsuario beUsuario;
        BllUsuario bllUsuario;
        public PerfilesForm(BelUsuario pUsuario)
        {
            InitializeComponent();
            beUsuario = pUsuario;
            bllUsuario = new BllUsuario();
            lbNombrePerfil.Text = pUsuario.Nombre;
            ActualizarPermisos();
            actualizarTree();
            ActualizarPerfiles();
            control();
        }
        private void RegistroReservas_Load(object sender, EventArgs e)
        {

        }
        private void actualizarTree()
        {
            treeView1.Nodes.Clear();
            TreeNode node = new TreeNode("Permisos");
            node.Name = "Permisos";
            treeView1.Nodes.Add(node);
            recursivaTreeView(PerfilManager.pCompuestoRaiz, node);
        }
        private void recursivaTreeView(PermisoCompuesto pCompuesto, TreeNode nodo)
        {
            foreach (Permiso p in pCompuesto.lPermiso)
            {
                TreeNode nodoT = new TreeNode(p.Nombre);
                nodoT.Name = p.Nombre;
                nodo.Nodes.Add(nodoT);
                if (p is PermisoCompuesto)
                {
                    nodo = nodoT;
                    recursivaTreeView(p as PermisoCompuesto, nodo);
                    nodo = nodoT.Parent;
                }
            }
        }
        private void ActualizarPermisos()
        {
            listBox2.Items.Clear();
            permisosRecursiva(PerfilManager.pCompuestoRaiz);
        }
        private void permisosRecursiva(PermisoCompuesto pRaiz)
        {
            foreach (Permiso permiso in pRaiz.lPermiso)
            {
                if (listBox2.FindString(permiso.Nombre) >= 0)
                {

                }
                else
                {
                    listBox2.Items.Add(permiso.Nombre.ToString());
                    if (permiso is PermisoCompuesto)
                    {
                        permisosRecursiva((PermisoCompuesto)permiso);
                    }
                }
            }
        }
        private void ActualizarPerfiles()
        {
            listBox1.Items.Clear();
            foreach (Perfil p in PerfilManager.lPerfil)
            {
                listBox1.Items.Add(p.Nombre);
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode == null && listBox1.SelectedItems == null)
                {
                    throw new Exception("Permiso no seleccionado");
                }
                string nombre = Interaction.InputBox("Nombre del perfil:");
                Permiso permiso = PerfilManager.pCompuestoRaiz.BuscarPermisoNombre(listBox2.Text, PerfilManager.pCompuestoRaiz);
                Perfil perfil = new Perfil(nombre, permiso);
                PerfilManager.AltaPerfil(perfil);
                ActualizarPerfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Perfil aux = PerfilManager.lPerfil.Find(x => x.Nombre == listBox1.Text);
            PerfilManager.BajaPerfil(int.Parse(aux.id));
            List<BelUsuario> listUsuario = bllUsuario.Consulta();
            if(listUsuario.Exists(x => x.Perfil == aux))
            {
                BelUsuario _usuario = listUsuario.Find(x => x.Perfil == aux);
                _usuario.Perfil = PerfilManager.lPerfil.Find(x => x.Nombre == "--");
                bllUsuario.Modificacion(_usuario);
            }
            ActualizarPerfiles();
            control();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Perfil aux = PerfilManager.lPerfil.Find(x => x.Nombre == listBox1.Text);
            beUsuario.Perfil = aux;
            lbNombrePerfil.Text = beUsuario.Perfil.Nombre;
            bllUsuario.Modificacion(beUsuario);
            control();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            PerfilManager.ActualizaListaPerfil();
        }
        public void control()
        {
            List<Permiso> permiso = new List<Permiso>();
            (SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto).RellenaArrayPermisos(SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto, permiso);
            foreach (Control c in this.Controls)
            {
                if(c is Button && c.Tag != null)
                {
                    (c as Button).Enabled = false;
                    foreach (Permiso p in permiso)
                    {
                        if(c.Tag.ToString() == p.Nombre)
                        {
                            (c as Button).Enabled = true;
                        }
                    }
                }
            }
        }
        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            labPerfil.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labPerfil").Texto;
            lbNombrePerfil.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbNombrePerfil").Texto;
            lbPerfil.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbPerfil").Texto;
            lbPermiso.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbPermiso").Texto;
            listBox1.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "listBox1").Texto;
            listBox2.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "listBox2").Texto;
            btnCrear.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCrear").Texto;
            btnBorrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnBorrar").Texto;
            btnAgregar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnAgregar").Texto;
            btnCerrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCerrar").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "PerfilesForm").Texto;
        }
    }
}
