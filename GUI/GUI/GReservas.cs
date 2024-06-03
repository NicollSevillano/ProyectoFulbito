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
    public partial class GReservas : Form
    {
        public SessionManager smanager;
        public GReservas()
        {
            InitializeComponent();
        }

        private void GReservas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();
        }
    }
}
