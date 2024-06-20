using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be;
using Dal;
using Interface;

namespace Mapper
{
    public class MapperCancha : IABMC<BeCancha>
    {
        public void Alta(BeCancha pObject)
        {
            throw new NotImplementedException();
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeCancha> Consulta()
        {
            throw new NotImplementedException();
        }

        public List<BeCancha> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeCancha pObject)
        {
            throw new NotImplementedException();
        }
    }
}
