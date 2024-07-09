using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeCancha : IEntity
    {
        public BeCancha(string pNombre, string precio)
        {
            Nombre = pNombre;
            Precio = precio;
        }
        public BeCancha() { }
        public BeCancha(object[] array)
        {
            id = array[0].ToString();
            Nombre = array[1].ToString();
        }
        public string id { get ; set ; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
    }
}
