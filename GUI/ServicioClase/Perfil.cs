using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class Perfil
    {
        public Perfil(string pNombre, Permiso pPermiso)
        {
            Nombre = pNombre; Permiso = pPermiso;
        }
        public Perfil(object[] array)
        {
            Id = int.Parse(array[0].ToString());
            Nombre = array[1].ToString();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Permiso Permiso { get; set; }
    }
}
