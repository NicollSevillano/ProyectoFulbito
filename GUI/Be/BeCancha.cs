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
        public BeCancha(string pNombre)
        {
            Nombre = pNombre;
        }
        public BeCancha() { }
        public BeCancha(object[] array)
        {
            id = array[0].ToString();
            Nombre = array[1].ToString();
        }
        public string id { get ; set ; }
        public string Nombre { get; set; }
        
    }
}
