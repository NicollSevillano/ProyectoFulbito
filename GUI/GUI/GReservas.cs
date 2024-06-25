using Be;
using Bll;
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
    public partial class GReservas : Form
    {
        public SessionManager smanager;
        List<BeCliente> lCliente;
        List<BeCancha> lCancha;
        List<BeReserva> lReserva;
        BeReserva breserva = new BeReserva();
        BllReserva blReserva;
        BllCliente blCliente;
        PerfilesForm registroReservas;
        GRegistrarCliente regisCliente;
        public GReservas()
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
            regisCliente = new GRegistrarCliente();
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
        private void ValidarCliente()
        {
            if (!CargarTXT())
            {
                string dni = txtDni.Text;
                if (lCliente.Exists(x => x.DNI == dni))
                {
                    btnRegistrar.Enabled = false;
                }
                else
                {
                    btnRegistrar.Enabled = true;
                    MessageBox.Show("Debe registrar al cliente");
                    regisCliente.Hide();
                    regisCliente.ShowDialog();
                }
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
            
            BeCancha bcancha1 = ObtenerCancha();
            BeCliente bcliente1 = ObtenerCliente();

            BeReserva reserva;
            reserva = new BeReserva(bcancha1, bcliente1, DateTime.Parse(dateTimePicker1.Text), TimeSpan.Parse(txtHorario.Text));
            blReserva.Alta(reserva);
            
            dgvReservas.Rows.Add(reserva.id, reserva.Cancha.Nombre, reserva.Cliente.Nombre, reserva.Fecha, reserva.Hora);
            lReserva = blReserva.Consulta();

        }
        private BeCancha ObtenerCancha()
        {
            string aux = cmbCancha.Text;
            BeCancha cancha = lCancha.Find(x => x.Nombre == aux);
            return cancha;
        }
        private BeCliente ObtenerCliente()
        {
            ValidarCliente();
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
            GRegistrarCliente gRegistrarC = new GRegistrarCliente();
            gRegistrarC.Hide();
            gRegistrarC.ShowDialog();
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
            List<BeReserva> lreserva = new List<BeReserva>();
            foreach (BeReserva r in lreserva)
            {
                dgvReservas.Rows.Add(r.id, r.Cancha.Nombre, r.Cliente.Nombre, r.Fecha, r.Hora);
                lreserva = blReserva.Consulta();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            CobrarReserva cobrarReserva = new CobrarReserva();
            cobrarReserva.Hide();
            cobrarReserva.ShowDialog();
        }
    }
}
