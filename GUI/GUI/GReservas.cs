using Be;
using Bll;
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
    public partial class GReservas : Form
    {
        List<BeCliente> lCliente;
        List<BeCancha> lCancha;
        List<BeReserva> lReserva;
        BllReserva blReserva;
        BeCliente bCliente;
        BllCliente blCliente;
        public GReservas()
        {
            InitializeComponent();
        }

        private void GReservas_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            dateTimePicker1.MinDate = fechaActual;
            monthCalendar1.MinDate = fechaActual;
            lCancha = new List<BeCancha>();
            blCliente = new BllCliente();
            lCliente = blCliente.Consulta();
            lReserva = new List<BeReserva>();
            blReserva = new BllReserva();
            Canchas();
        }
        private bool CargarTXT()
        {
            bool cargar = false;
            if(txtDni.Text == string.Empty || txtNombre.Text == string.Empty)
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
                if(!lCliente.Exists(x => x.DNI == dni))
                {
                    btnRegistrar.Enabled = true;
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
            BeReserva reserva;
            reserva = new BeReserva(ObtenerCancha(), ObtenerCliente(), DateTime.Parse(dateTimePicker1.Text), TimeSpan.Parse(cmbHorario.Text));
            blReserva.Alta(reserva);
            blReserva.Consulta();
        }
        private void RefrescarListBox()
        {
            listBox1.Items.Clear();
            foreach (BeReserva be in lReserva)
            {
                //listBox1.Items.Add(be.Cancha, be.Cliente, be.Fecha, be.Hora);
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
            string aux2 = txtDni.Text;
            BeCliente cliente = lCliente.Find(x => x.DNI == aux2);
            return cliente;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
