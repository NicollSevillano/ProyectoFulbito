using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class PermisoCompuesto : Permiso
    {
        public override int Id { get; set; }
        public override string Nombre { get; set; }
        public List<Permiso> lPermiso;
        public PermisoCompuesto(string pNombre)
        {
            Nombre = pNombre;
            lPermiso = new List<Permiso>();
        }
        public PermisoCompuesto(object[] array)
        {
            Id = int.Parse(array[0].ToString());
            Nombre = array[1].ToString();
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
            if (pPermisoActual.lPermiso.Count > 0)
            {
                foreach (Permiso p in pPermisoActual.lPermiso)
                {
                    if (p is PermisoCompuesto)
                    {
                        if ((p as PermisoCompuesto).lPermiso.Exists(x => x.Id == Id))
                        {
                            pPermiso = (p as PermisoCompuesto).lPermiso.Find(x => x.Id == Id);
                        }
                        else
                        {
                            pPermiso = BuscarPermisoIdRecursiva(pId, p as PermisoCompuesto, pPermiso);

                        }
                    }
                }
            }
            return pPermiso;
        }
    }
}
