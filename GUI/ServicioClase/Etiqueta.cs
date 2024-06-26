using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class Etiqueta
    {
        public Etiqueta(int pCodigo, string pControl, string pTexto)
        {
            CodigoEtiqueta = pCodigo;
            ControlT = pControl;
            Texto = pTexto;
        }
        public Etiqueta(object[] array)
        {
            CodigoEtiqueta = int.Parse(array[0].ToString());
            ControlT = array[1].ToString();
            Texto = array[2].ToString();
        }
        public int CodigoEtiqueta { get; set; }
        public string ControlT { get; set; }
        public string Texto { get; set; }
    }
}
