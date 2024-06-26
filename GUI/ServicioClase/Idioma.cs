using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class Idioma
    {
        public Idioma(int pCodigo, string pNombre)
        {
            CodigoIdioma = pCodigo;
            Nombre = pNombre;
            lEtiqueta = new List<Etiqueta>();
        }
        public Idioma(object[] array)
        {
            CodigoIdioma = int.Parse(array[0].ToString());
            Nombre = array[1].ToString();
        }
        public int CodigoIdioma { get; set; }
        public string Nombre { get; set; }
        public List<Etiqueta> lEtiqueta { get; set; }
    }
}
