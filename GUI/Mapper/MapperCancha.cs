using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
        Dao dao = new Dao();
        ArrayList arraylist;
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
            string listarCancha = "sp_Listar_Cancha";
            DataTable dt = dao.Leer(listarCancha);
            List<BeCancha> lCancha = new List<BeCancha>();
            foreach (DataRow dr in dt.Rows)
            {
                BeCancha aux = new BeCancha(dr.ItemArray);
                lCancha.Add(aux);
            }
            return lCancha;
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
