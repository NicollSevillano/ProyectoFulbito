using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class PermisoSimple : Permiso
    {
        public PermisoSimple(object[] array)
        {
            Id = int.Parse(array[0].ToString());
            Nombre = array[1].ToString();
        }
        public override int Id { get; set; }
        public override string Nombre { get; set; }
    }
}
