using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Sistema
{
    public class UsuariosADO
    {
        private DB_BOUTIQUEEntities contexto;

        public UsuariosADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(USUARIO entidad)
        {
            contexto.USUARIO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(USUARIO entidad)
        {
            contexto.USUARIO.Remove(entidad);
        }

        public List<USUARIO> Listar()
        {
            return contexto.USUARIO.ToList();
        }

        public USUARIO Obtener(int id)
        {
            return contexto.USUARIO.FirstOrDefault(x => x.Id == id);
        }

        public List<clsUSUARIO> ListarUsuarios()
        {
            string _query = "SELECT "+
                            "US.Id, US.Alias, RL.Nombre AS Rol, EDO.Nombre as Estado "+
                            "FROM USUARIO AS US "+
                            "JOIN ROL AS RL ON US.ROLId = RL.Id "+
                            "JOIN ESTADO AS EDO ON US.ESTADOId = EDO.Id";

            return contexto.Database.SqlQuery<clsUSUARIO>(_query).ToList();
        }


       
    }
}
