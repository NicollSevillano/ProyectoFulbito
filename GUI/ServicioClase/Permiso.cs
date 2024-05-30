using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public abstract class Permiso
    {
        public abstract int Id { get; set; }
        public abstract string Nombre { get; set; }
    }
}
