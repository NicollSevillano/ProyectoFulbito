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
    public partial class RegistroReservas : Form
    {
        BeReserva beReserva = new BeReserva(); 
        BllReserva bllReserva = new BllReserva();
        public RegistroReservas()
        {
            InitializeComponent();
        }

        private void RegistroReservas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void Refrescar()
        {
            List<BeReserva> lReserva = new List<BeReserva>();
            foreach (BeReserva be in lReserva)
            {
                dgvRegistro.Rows.Add(be.id, be.Cancha.Nombre, be.Cliente.DNI, be.Cliente.Nombre, be.Cliente.Telefono, be.Fecha, be.Hora);
                lReserva = bllReserva.Consulta();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
