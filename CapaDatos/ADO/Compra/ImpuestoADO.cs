using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Compra
{
    public class ImpuestoADO
    {
        private DB_BOUTIQUEEntities contexto;

        public ImpuestoADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(IMPUESTO entidad)
        {
            contexto.IMPUESTO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(IMPUESTO entidad)
        {
            contexto.IMPUESTO.Remove(entidad);
        }

        public List<IMPUESTO> Listar()
        {
            return contexto.IMPUESTO.ToList();
        }

        public IMPUESTO Obtener(int id)
        {
            return contexto.IMPUESTO.FirstOrDefault(x => x.Id == id);
        }

       
    }
}
