using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Sistema
{
    public class EstadoADO
    {
        private DB_BOUTIQUEEntities contexto;

        public EstadoADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(ESTADO entidad)
        {
            contexto.ESTADO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(ESTADO entidad)
        {
            contexto.ESTADO.Remove(entidad);
        }

        public List<ESTADO> Listar()
        {
            return contexto.ESTADO.ToList();
        }

        public ESTADO Obtener(int id)
        {
            return contexto.ESTADO.FirstOrDefault(x => x.Id == id);
        }
    }
}
