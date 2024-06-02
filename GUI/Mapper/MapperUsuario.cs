using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be;
using Dal;
using Interface;
using ServicioClase;
using Servicios;

namespace Mapper
{
    public class MapperUsuario : IABMC<BelUsuario>
    {
        Dao dao = new Dao();
        ArrayList arrayList;
        public void Alta(BelUsuario pObject)
        {
            arrayList = new ArrayList();

            string storeAlta = "sp_Usuario_Alta";

            SqlParameter p1 = new SqlParameter();
            p1.Value = pObject.DNI;
            p1.ParameterName = "@DNI";
            p1.SqlValue = SqlDbType.NVarChar;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = pObject.Nombre;
            p2.ParameterName = "@Nombre";
            p2.SqlValue = SqlDbType.NVarChar;
            arrayList.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.Value = pObject.Apellido;
            p3.ParameterName = "@Apellido";
            p3.SqlValue = SqlDbType.NVarChar;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.Value = pObject.Email;
            p4.ParameterName = "@Email";
            p4.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.Value = pObject.Perfil.Id; 
            p5.ParameterName = "@Rol";
            p5.SqlDbType = SqlDbType.Int;
            arrayList.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.Value = pObject.Usuario;
            p6.ParameterName = "@Usuario";
            p6.SqlDbType = SqlDbType.VarChar;
            arrayList.Add(p6);

            SqlParameter p8 = new SqlParameter();
            p8.Value = pObject.Contraseña;
            p8.ParameterName = "@Contraseña";
            p8.SqlDbType = SqlDbType.VarChar;
            arrayList.Add(p8);

            dao.Escribir(storeAlta, arrayList);
        }
        public void Baja(int pId)
        {
            arrayList = new ArrayList();
            string storeBaja = "sp_Usuario_Borrar";

            SqlParameter p1 = new SqlParameter();
            p1.Value = pId;
            p1.ParameterName = "@CodigoUsuario";
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            dao.Escribir(storeBaja, arrayList);
        }

        public List<BelUsuario> Consulta()
        {
            string storePConsulta = "sp_Usuario_Listar";
            DataTable dtConsulta = dao.Leer(storePConsulta);
            List<BelUsuario> aux = new List<BelUsuario>();
            PerfilManager pM = new PerfilManager();
            foreach (DataRow drow in dtConsulta.Rows)
            {
                BelUsuario usuario = new BelUsuario(drow.ItemArray);
                usuario.Perfil = pM.lPerfil.Find(x => x.Id == int.Parse(drow[5].ToString()));
                aux.Add(usuario);
            }
            return aux;
        }

        public List<BelUsuario> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BelUsuario pObject)
        {
            arrayList = new ArrayList();
            string storeModificar = "sp_Usuario_Modificar";

            SqlParameter p1 = new SqlParameter();
            p1.Value = pObject.id;
            p1.ParameterName = "@CodigoUsuario";
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = pObject.DNI;
            p2.ParameterName = "@DNI";
            p2.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.Value = pObject.Nombre;
            p3.ParameterName = "@Nombre";
            p3.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.Value = pObject.Apellido;
            p4.ParameterName = "@Apellido";
            p4.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.Value = pObject.Email;
            p5.ParameterName = "@Email";
            p5.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.Value = pObject.Perfil.Id;
            p6.ParameterName = "@Rol";
            p6.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.Value = pObject.Usuario;
            p7.ParameterName = "@Usuario";
            p7.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p7);

            SqlParameter p8 = new SqlParameter();
            p8.Value = pObject.Contraseña;
            p8.ParameterName = "@Contraseña";
            p8.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p8);

            dao.Escribir(storeModificar, arrayList);
        }
        public void EstadoBloqueado(BelUsuario pUsuario)
        {
            arrayList = new ArrayList();
            string estadoBloqueado = "sp_Usuario_EstadoBloqueado";

            SqlParameter p1 = new SqlParameter();
            p1.Value = pUsuario.id;
            p1.ParameterName = "@CodigoUsuario";
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = pUsuario.Bloqueado ? false : true;
            p2.ParameterName = "@Bloqueado";
            p2.SqlDbType = SqlDbType.Bit;
            arrayList.Add(p2);

            dao.Escribir(estadoBloqueado, arrayList);
        }
        public void EstadoActivo(BelUsuario pUsuario)
        {
            arrayList = new ArrayList();
            string estadoActivo = "sp_Usuario_EstadoActivo";

            SqlParameter p1 = new SqlParameter();
            p1.Value = pUsuario.id;
            p1.ParameterName = "@CodigoUsuario";
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = pUsuario.Activo ? false : true;
            p2.ParameterName = "@Activo";
            p2.SqlDbType = SqlDbType.Bit;
            arrayList.Add(p2);
            dao.Escribir(estadoActivo, arrayList);
        }
    }
}
