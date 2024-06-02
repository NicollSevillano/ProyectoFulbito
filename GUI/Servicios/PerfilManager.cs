using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using ServicioClase;

namespace Servicios
{
    public class PerfilManager
    {
        public Dao dao;
        public PermisoCompuesto pCompuestoRaiz;
        public List<Perfil> lPerfil;
        public ArrayList arrayList;
        public PerfilManager()
        {
            dao = new Dao();
            pCompuestoRaiz = new PermisoCompuesto("Raiz");
            lPerfil = ConsultaPerfil();
        }
        //Permisos
        private void RelacionPermiso(PermisoCompuesto pPermiso, DataTable pRelaciones, List<Permiso> pLista)
        {
            foreach (DataRow dRow in pRelaciones.Rows)
            {
                if (dRow[0].ToString() == (pPermiso.Id).ToString())
                {
                    pPermiso.AgregarPermiso(pLista.Find(x => (x.Id).ToString() == dRow[1].ToString()));
                }
            }
        }
        private void ActuralizarPermisos()
        {
            pCompuestoRaiz = ConsultaPermiso()[0] as PermisoCompuesto;
        }
        public List<Permiso> ConsultaPermiso()
        {
            //Conseguir la lista de permisos 
            arrayList = new ArrayList();
            string storeConsulta = "sp_Listar_Permiso";
            DataTable dt = dao.Leer(storeConsulta);
            List<Permiso> arbol = new List<Permiso>();
            List<Permiso> listaPermiso = new List<Permiso>();

            foreach (DataRow dRow in dt.Rows)
            {
                if (bool.Parse(dRow[2].ToString()) == false)
                {
                    PermisoSimple pSimple = new PermisoSimple(dRow.ItemArray);
                    listaPermiso.Add(pSimple);
                }
                else
                {
                    PermisoCompuesto pCompuesto = new PermisoCompuesto(dRow.ItemArray);
                    listaPermiso.Add(pCompuesto);
                }
            }
            //armo las relaciones entre los permisos
            string storeCRelaciones = "sp_Listar_Relaciones";
            DataTable dT = dao.Leer(storeCRelaciones);
            PermisoCompuesto pCompuestoRelacion = new PermisoCompuesto("nRaiz");
            foreach (Permiso p in listaPermiso)
            {
                if (p is PermisoCompuesto)
                {
                    RelacionPermiso(p as PermisoCompuesto, dT, listaPermiso);
                    pCompuestoRelacion.AgregarPermiso(p);
                }
            }
            arbol.Add(pCompuestoRelacion);
            return arbol;
        }
        private void AltaPermiso(Permiso pObject, Permiso pPadre = null)
        {
            arrayList = new ArrayList();
            string storeAlta = "sp_Alta_Permiso";

            SqlParameter p1 = new SqlParameter();
            p1.Value = pObject.Nombre;
            p1.ParameterName = "@Nombre";
            p1.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            if (pObject is PermisoCompuesto)
            {
                p2.Value = true;
            }
            else
            {
                p2.Value = false;
            }
            p2.ParameterName = "@esCompuesto";
            p2.SqlDbType = SqlDbType.Bit;
            arrayList.Add(p2);

            dao.Escribir(storeAlta, arrayList);

            //Relación con padre
            if (pPadre != null)
            {
                arrayList = new ArrayList();
                SqlParameter p3 = new SqlParameter();
                p3.Value = pPadre.Id;
                p2.ParameterName = "@Compuesto";
                p3.SqlDbType = SqlDbType.Int;
                arrayList.Add(p3);

                SqlParameter p4 = new SqlParameter();
                p4.ParameterName = "@Simple";
                p4.SqlValue = SqlDbType.NVarChar;
                p4.Value = UltimoIdPermiso();
                arrayList.Add(p4);

                dao.Escribir(storeAlta, arrayList);
            }
        }
        private string UltimoIdPermiso()
        {
            string storeUltimo = "sp_ListarUltimo_Permiso";
            DataTable dt = dao.Leer(storeUltimo);
            string id = dt.Rows[0].ItemArray[0].ToString();
            return id;
        }
        private void BajaPermiso(int pId)
        {
            //Eliminar permiso
            arrayList = new ArrayList();
            string storeBaja = "sp_Eliminar_Permiso";

            SqlParameter p1 = new SqlParameter();
            p1.Value = pId;
            p1.ParameterName = "@CodigoUsuario";
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);
            dao.Escribir(storeBaja, arrayList);

            //Eliminar relación permiso
            storeBaja = "sp_EliminarRelacion_Permiso";
            dao.Escribir(storeBaja, arrayList);

            ActuralizarPermisos();
        }
        //Perfiles
        public List<Perfil> ConsultaPerfil()
        {
            string storeListarPerfil = "sp_Listar_Perfil";
            DataTable dt = dao.Leer(storeListarPerfil);
            List<Perfil> lPerfil = new List<Perfil>();

            foreach (DataRow dr in dt.Rows)
            {
                Perfil aux = new Perfil(dr.ItemArray);
                aux.Permiso = pCompuestoRaiz.BuscarPermisoId(dr[2].ToString(), pCompuestoRaiz);
                lPerfil.Add(aux);
            }
            return lPerfil;
        }
        public void AltaPerfil(Perfil pObject) 
        {
            arrayList = new ArrayList();
            string storeAltaPerfil = "sp_Alta_Perfil";
            SqlParameter p1 = new SqlParameter();
            p1.Value = pObject.Nombre;
            p1.ParameterName = "@Nombre";
            p1.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = pObject.Permiso.Id;
            p2.ParameterName = "@Permiso";
            p2.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p2);
            ActualizarPerfil();

            dao.Escribir(storeAltaPerfil, arrayList);
        }
        public void ActualizarPerfil()
        {
            lPerfil = ConsultaPerfil();
        }
        public void BajaPerfil(int pId)
        {
            arrayList = new ArrayList();
            string storeBajaPerfil = "sp_Eliminar_Perfil";
            SqlParameter p1 = new SqlParameter();
            p1.Value = pId;
            p1.ParameterName = "@@CodigoPerfil";
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);
            dao.Escribir(storeBajaPerfil, arrayList);

            ActualizarPerfil();
        }
    }
}
