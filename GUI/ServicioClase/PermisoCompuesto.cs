using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class PermisoCompuesto : Permiso
    {
        public List<Permiso> lPermiso;
        public PermisoCompuesto(string pNombre)
        {
            Nombre = pNombre;
            lPermiso = new List<Permiso>();
        }
        public PermisoCompuesto(object[] array)
        {
            id = array[0].ToString();
            Nombre = array[1].ToString();
            lPermiso = new List<Permiso>();
        }
        public void AgregarPermiso(Permiso pPermiso)
        {
            lPermiso.Add(pPermiso);
        }
        public void EliminarPermiso(Permiso pPermiso)
        {
            lPermiso.Remove(pPermiso);
        }
        public Permiso BuscarPermisoId(string pId, PermisoCompuesto pPermisoAct)
        {
            return BuscarPermisoIdRecursiva(pId, pPermisoAct, null);
        }
        //Permiso PermisoBuscado = new PermisoCompuesto() 
        //Buscar PermisoId(se busca el Id, raiz, PermisoBuscado) 
        public Permiso BuscarPermisoIdRecursiva(string pId, PermisoCompuesto pPermisoActual, Permiso pPermiso)
        {
            if(pPermisoActual.id != pId)
            {
                if (pPermisoActual.lPermiso.Count > 0)
                {
                    foreach (Permiso p in pPermisoActual.lPermiso)
                    {
                        if (p is PermisoCompuesto)
                        {
                            if ((p as PermisoCompuesto).lPermiso.Exists(x => x.id == id))
                            {
                                pPermiso = (p as PermisoCompuesto).lPermiso.Find(x => x.id == id);
                            }
                            else
                            {
                                pPermiso = BuscarPermisoIdRecursiva(pId, p as PermisoCompuesto, pPermiso);

                            }
                        }
                    }
                }
            }
            else
            {
                pPermiso = pPermisoActual;
            }
            return pPermiso;
        }
        public void RellenaArrayPermisos(PermisoCompuesto pPermisoActual, List<Permiso> pLista)
        {
            foreach (Permiso p in pPermisoActual.lPermiso)
            {
                pLista.Add(p);
                if (p is PermisoCompuesto)
                {
                    RellenaArrayPermisos(p as PermisoCompuesto, pLista);
                }
            }
        }
    }
}
