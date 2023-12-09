using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Inventario
{
    public class TipoMovimientoADO
    {
        private DB_BOUTIQUEEntities contexto;

        public TipoMovimientoADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(TIPO_MOVIMIENTO entidad)
        {
            contexto.TIPO_MOVIMIENTO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(TIPO_MOVIMIENTO entidad)
        {
            contexto.TIPO_MOVIMIENTO.Remove(entidad);
        }

        public List<TIPO_MOVIMIENTO> Listar()
        {
            return contexto.TIPO_MOVIMIENTO.ToList();
        }

        public TIPO_MOVIMIENTO Obtener(int id, bool tipo)
        {
            return contexto.TIPO_MOVIMIENTO.FirstOrDefault(x => x.Id == id && x.Tipo==tipo);
        }
    }
}
