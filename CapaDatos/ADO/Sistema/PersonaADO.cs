using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Sistema
{
    public class PersonaADO
    {
        private DB_BOUTIQUEEntities contexto;

        public PersonaADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(PERSONA entidad)
        {
            contexto.PERSONA.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(PERSONA entidad)
        {
            contexto.PERSONA.Remove(entidad);
        }

        public List<PERSONA> Listar()
        {
            return contexto.PERSONA.ToList();
        }

        public PERSONA Obtener(int id)
        {
            return contexto.PERSONA.FirstOrDefault(x=>x.Id==id);
        }

    }
}
