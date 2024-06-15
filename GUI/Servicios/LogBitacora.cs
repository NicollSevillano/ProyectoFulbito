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
        Dao dao = new Dao();
        ArrayList arrayList;

        public void Agregar()
        {
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@Fecha";
            p1.Value = DateTime.Now;
            p1.SqlDbType = System.Data.SqlDbType.DateTime;
        }
    }
}
