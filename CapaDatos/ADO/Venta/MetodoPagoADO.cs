using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Venta
{
    public class MetodoPagoADO
    {
        private DB_BOUTIQUEEntities contexto;

        public MetodoPagoADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(METODOPAGO entidad)
        {
            contexto.METODOPAGO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(METODOPAGO entidad)
        {
            contexto.METODOPAGO.Remove(entidad);
        }

        public List<METODOPAGO> Listar()
        {
            return contexto.METODOPAGO.ToList();
        }

        public METODOPAGO Obtener(int id)
        {
            return contexto.METODOPAGO.FirstOrDefault(x => x.Id == id);
        }
    }
}
