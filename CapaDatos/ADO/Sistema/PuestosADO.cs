using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Sistema
{
    public class PuestosADO
    {
        private DB_BOUTIQUEEntities contexto;

        public PuestosADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(PUESTO entidad)
        {
            contexto.PUESTO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(PUESTO entidad)
        {
            contexto.PUESTO.Remove(entidad);
        }

        public List<PUESTO> Listar()
        {
            return contexto.PUESTO.ToList();
        }

        public PUESTO Obtener(int id)
        {
            return contexto.PUESTO.FirstOrDefault(x => x.Id == id);
        }
    }
}
