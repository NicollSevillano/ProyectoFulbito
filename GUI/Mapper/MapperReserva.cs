using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Be;
using Dal;
using Interface;

namespace Mapper
{
    public class MapperReserva : IABMC<BeReserva>
    {
        ArrayList al;
        Dao dao = new Dao();
        BeCancha cancha = new BeCancha();
        public void Alta(BeReserva pObject)
        {
            string storeAltaRerva = "sp_Alta_Reserva";
            al = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoCancha";
            p1.Value = pObject.Cancha.id;
            p1.SqlDbType = System.Data.SqlDbType.NVarChar;
            al.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@CodigoCliente";
            p2.Value = pObject.Cliente.id;
            p2.SqlDbType = System.Data.SqlDbType.Int;
            al.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Fecha";
            p3.Value = pObject.Fecha;
            p3.SqlDbType = System.Data.SqlDbType.DateTime;
            al.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Hora";
            p4.Value = pObject.Hora;
            p4.SqlDbType = System.Data.SqlDbType.Timestamp;
            al.Add(p4);

            dao.Escribir(storeAltaRerva, al);
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeReserva> Consulta()
        {
            string storeListReserva = "sp_Listar_Reserva";
            DataTable dt = dao.Leer(storeListReserva);
            List<BeReserva> lReserva = new List<BeReserva>();

            foreach (DataRow dr in dt.Rows)
            {
                BeReserva aux = new BeReserva(dr.ItemArray);
                lReserva.Add(aux);
            }
            return lReserva;
        }

        public List<BeReserva> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeReserva pObject)
        {
            throw new NotImplementedException();
        }
    }
}
