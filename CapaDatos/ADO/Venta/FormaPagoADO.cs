using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Venta
{
    public class FormaPagoADO
    {
        private DB_BOUTIQUEEntities contexto;

        public FormaPagoADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(FORMAPAGO entidad)
        {
            contexto.FORMAPAGO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(FORMAPAGO entidad)
        {
            contexto.FORMAPAGO.Remove(entidad);
        }

        public List<FORMAPAGO> Listar()
        {
            return contexto.FORMAPAGO.ToList();
        }

        public FORMAPAGO Obtener(int id)
        {
            return contexto.FORMAPAGO.FirstOrDefault(x => x.Id == id);
        }
    }
}
