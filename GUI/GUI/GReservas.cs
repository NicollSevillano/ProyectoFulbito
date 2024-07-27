using Be;
using Bll;
using Interface;
using ServicioClase;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GReservasForm : Form, ITraducible
    {
        public SessionManager smanager;
        List<BeCliente> lCliente;
        List<BeCancha> lCancha;
        List<BeReserva> lReserva;
        BeReserva breserva = new BeReserva();
        BllReserva blReserva;
        BllCliente blCliente;
        PerfilesForm registroReservas;
        GRegistrarClienteForm regisCliente;
        public GReservasForm()
        {
            InitializeComponent();
        }

        private void GReservas_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;
            dateTimePicker1.MinDate = fechaActual;
            monthCalendar1.MinDate = fechaActual;
            lCancha = new List<BeCancha>();
            blCliente = new BllCliente();
            blReserva = new BllReserva();
            lReserva = blReserva.Consulta();
            lCliente = blCliente.Consulta();
            regisCliente = new GRegistrarClienteForm();
            lCliente = blCliente.Consulta();
            ValidarCliente();
            Canchas();
            //Refrescar();
        }

        private bool CargarTXT()
        {
            bool cargar = false;
            if (txtDni.Text == string.Empty)
            {
                cargar = true;
            }
            return cargar;
        }
        private bool ValidarCliente()
        {
            string dni = txtDni.Text;
            if (lCliente.Exists(x => x.DNI == dni))
                {
                    btnRegistrar.Enabled = false;
                    return true;
                }
            else
            {
                btnRegistrar.Enabled = true;
                return false;
            }
            
        }
        private void Canchas()
        {
            cmbCancha.Items.Clear();
            BllCancha blCancha = new BllCancha();
            List<BeCancha> lCancha = blCancha.Consulta();
            foreach (BeCancha l in lCancha)
            {
                cmbCancha.Items.Add(l.Nombre);
            }
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (ValidarCliente())
            {
                BeCancha bcancha1 = ObtenerCancha();
                BeCliente bcliente1 = ObtenerCliente();

                BeReserva reserva;
                
                reserva = new BeReserva(bcancha1, bcliente1, DateTime.Parse(dateTimePicker1.Text), TimeSpan.Parse(txtHorario.Text));
                blReserva.Alta(reserva);
                lReserva = blReserva.Consulta();
                Refrescar();
                MessageBox.Show("No se olvide de pagar la reserva!!");
            }
            else
            {
                MessageBox.Show("Debe registrar al cliente para reservar");
            }
        }
        private BeCancha ObtenerCancha()
        {
            string aux = cmbCancha.Text;
            BeCancha cancha = lCancha.Find(x => x.Nombre == aux);
            return cancha;
        }
        private BeCliente ObtenerCliente()
        {
            lCliente = blCliente.Consulta();
            string aux = txtDni.Text;
            BeCliente cliente = lCliente.Find(x => x.DNI == aux);
            return cliente;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(dateTimePicker1.Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado =  MessageBox.Show("¿Desea cancelar la reserva?","Salir", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GRegistrarClienteForm gRegistrarC = new GRegistrarClienteForm();
            gRegistrarC.Hide();
            gRegistrarC.ShowDialog();
            lCliente = blCliente.Consulta();
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
        private BeReserva LlamarReserva()
        {
            return lReserva.Find(x => x.id == dgvReservas.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void Refrescar()
        {
            dgvReservas.Rows.Clear();
            foreach (BeReserva r in lReserva)
            {
                dgvReservas.Rows.Add(r.id, r.Cancha.Nombre, r.Cliente.Nombre, r.Fecha, r.Hora);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0) { MessageBox.Show("Tiene que seleccionar una reserva"); return; }
            CobrarReservaForm cobrarReserva = new CobrarReservaForm(LlamarReserva());
            LanguageManager.Suscribir(cobrarReserva);
            cobrarReserva.Hide();
            cobrarReserva.ShowDialog();
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            labCancha.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labCancha").Texto;
            labDni.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labDni").Texto;
            labFecha.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labFecha").Texto;
            labHorario.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labHorario").Texto;
            btnDisponibilidad.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnDisponibilidad").Texto;
            btnRegistrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnRegistrar").Texto;
            btnCobrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCobrar").Texto;
            btnReservar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnReservar").Texto;
            ColumnaIdR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaIdR").Texto;
            ColumnaCanchaR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaCanchaR").Texto;
            ColumnaClienteR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaClienteR").Texto;
            ColumnaFechaR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaFechaR").Texto;
            ColumnaHorarioR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaHorarioR").Texto;
            btnSalirR.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalirR").Texto;
            //btnCancelarReserva.Text = _idioma.lEtiqueta.Find(X => X.ControlT == "btnCancelarReserva").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "GReservasForm").Texto;
        }

        private void btnSalirR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Usted está por cancelar la reserva", "Cancelar reserva", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                txtDni.Clear();
                cmbCancha.Items.Clear();
                txtHorario.Clear();
            }
            else
            {

            }
        }
    }
}
