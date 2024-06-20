using Be;
using Dal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class LogBitacora
    {
        static Dao dao = new Dao();
        static ArrayList arrayList;

        public static void Agregar(string pLog, int pCriticidad, BelUsuario pUsuario)
        {
            string altaBitacora = "sp_Alta_Bitacora";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@Fecha";
            p1.Value = DateTime.Now;
            p1.SqlDbType = System.Data.SqlDbType.DateTime;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Texto";
            p2.Value = pLog;
            p2.SqlDbType = System.Data.SqlDbType.NVarChar;
            arrayList.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Criticidad";
            p3.Value = pCriticidad;
            p3.SqlDbType = System.Data.SqlDbType.Int;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@CodigoUsuario";
            p4.Value = pUsuario.Usuario;
            p4.SqlDbType = System.Data.SqlDbType.Int;
            arrayList.Add(p4);

            dao.Escribir(altaBitacora, arrayList);
        }
        public static void AgregarLogCambio(BeCancha pCancha, BelUsuario pUsuario)
        {

        }
    }
}
