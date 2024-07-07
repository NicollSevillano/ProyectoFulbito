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
            lCliente = blCliente.Consulta();
            lReserva = new List<BeReserva>();
            blReserva = new BllReserva();
            regisCliente = new GRegistrarClienteForm();
            lCliente = blCliente.Consulta();
            ValidarCliente();
            Canchas();
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
            lCancha.AddRange(new BeCancha[] {new BeCancha() { id = "1", Nombre = "Cancha 5 A"},
                                             new BeCancha() { id = "2", Nombre = "Cancha 5 B"},
                                             new BeCancha() { id = "3", Nombre = "Cancha 5 C"},
                                             new BeCancha() { id = "4", Nombre = "Cancha 7 A"},
                                             new BeCancha() { id = "5", Nombre = "Cancha 7 B"},
                                             new BeCancha() { id = "7", Nombre = "Cancha 7 C"},
                                             new BeCancha() { id = "8", Nombre = "Cancha 7 D"},
                                             new BeCancha() { id = "9", Nombre = "Cancha 11 A"},
                                             new BeCancha() { id = "10", Nombre = "Cancha 11 B"}});

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
                dgvReservas.Rows.Add(reserva.id, reserva.Cancha.Nombre, reserva.Cliente.Nombre, reserva.Fecha, reserva.Hora);
                //Refrescar();
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

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void Refrescar()
        {
            List<BeReserva> lreserva = blReserva.Consulta();
            foreach (BeReserva r in lreserva)
            {
                dgvReservas.Rows.Add(r.id, r.Cancha.Nombre, r.Cliente.Nombre, r.Fecha, r.Hora);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            CobrarReservaForm cobrarReserva = new CobrarReservaForm();
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
            btnCancelar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCancelar").Texto;
            btnRegistrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnRegistrar").Texto;
            btnCobrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCobrar").Texto;
            btnReservar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnReservar").Texto;
            ColumnaIdR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaIdR").Texto;
            ColumnaCanchaR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaCanchaR").Texto;
            ColumnaClienteR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaClienteR").Texto;
            ColumnaFechaR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaFechaR").Texto;
            ColumnaHorarioR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaHorarioR").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "GReservasForm").Texto;
        }
    }
}
