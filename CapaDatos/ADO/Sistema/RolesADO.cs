using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Sistema
{
    public class RolesADO
    {
        private DB_BOUTIQUEEntities contexto;

        public RolesADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(ROL entidad)
        {
            contexto.ROL.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(ROL entidad)
        {
            contexto.ROL.Remove(entidad);
        }

        public List<ROL> Listar()
        {
            return contexto.ROL.ToList();
        }

        public ROL Obtener(int id)
        {
            return contexto.ROL.FirstOrDefault(x=>x.Id== id);
        }
    }
}
