using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Venta
{
    public class ClienteADO
    {
        private DB_BOUTIQUEEntities contexto;

        public ClienteADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(CLIENTE entidad)
        {
            contexto.CLIENTE.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(CLIENTE entidad)
        {
            contexto.CLIENTE.Remove(entidad);
        }

        public List<CLIENTE> Listar()
        {
            return contexto.CLIENTE.ToList();
        }

        public CLIENTE Obtener(int id)
        {
            return contexto.CLIENTE.FirstOrDefault(x => x.Id == id);
        }

        public clsCLIENTE ObtenerClienteData(int id)
        {
            string _query = "SELECT " +
                            "CLI.Id, CLI.Clave, (PER.Nombres + ' ' + PER.ApellidoPaterno + ' ' + PER.ApellidoMaterno) AS Nombre, " +
                            "PER.Nombres, PER.ApellidoPaterno, PER.ApellidoMaterno,  " +
                            "EDO.Id as EstadoId, EDO.Nombre as Estado, CLI.RFC as Rfc, CLI.RazonSocial, PER.Id as PersonaId, " +
                            "CLI.FechaRegistro, PER.FechaNacimiento " +
                            "FROM CLIENTE AS CLI " +
                            "JOIN PERSONA AS PER ON CLI.PERSONAId = PER.ID " +
                            "JOIN ESTADO AS EDO ON CLI.ESTADOId = EDO.Id " +
                            "WHERE CLI.Id = "+id;

            return contexto.Database.SqlQuery<clsCLIENTE>(_query).FirstOrDefault();
        }


        public List<clsCLIENTE> ListarClientes()
        {
            string _query = "SELECT "+
                            "CLI.Id, CLI.Clave, (PER.Nombres + ' ' + PER.ApellidoPaterno + ' ' + PER.ApellidoMaterno) AS Nombre, "+
                            "PER.Nombres, PER.ApellidoPaterno, PER.ApellidoMaterno,  "+
                            "EDO.Id as EstadoId, EDO.Nombre as Estado, CLI.RFC as Rfc, CLI.RazonSocial, PER.Id as PersonaId, "+
                            "CLI.FechaRegistro, PER.FechaNacimiento "+
                            "FROM CLIENTE AS CLI "+
                            "JOIN PERSONA AS PER ON CLI.PERSONAId = PER.ID "+
                            "JOIN ESTADO AS EDO ON CLI.ESTADOId = EDO.Id ";

            return contexto.Database.SqlQuery<clsCLIENTE>(_query).ToList();
        }

    }
}
