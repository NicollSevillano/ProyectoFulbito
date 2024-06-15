using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeReserva : IEntity
    {
        public string id { get ; set ; }
        public DateTime Fecha { get; set; }
        public List<BeCliente> Cliente { get; set; }
        public List<BeCancha> Cancha { get; set; }
    }
}
