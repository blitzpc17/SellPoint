using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Sistema
{
    public class EmpleadosADO
    {
        private DB_BOUTIQUEEntities contexto;

        public EmpleadosADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(EMPLEADO entidad)
        {
            contexto.EMPLEADO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(EMPLEADO entidad)
        {
            contexto.EMPLEADO.Remove(entidad);
        }

        public List<EMPLEADO> Listar()
        {
            return contexto.EMPLEADO.ToList();
        }

        public clsEMPLEADO Obtener(int id)
        {
            string _query = "SELECT "+
                            "EMP.Id AS EmpleadoId,"+
                            "EMP.Rfc, "+
                            "EMP.FechaIngreso, "+
                            "EDO.Nombre as Estado, EDO.Id as EstadoId, "+
                            "PUES.Nombre as Puesto, PUES.Id as PuestoId, "+
                            "PER.Id as PersonaId, PER.Nombres, PER.ApellidoPaterno, PER.ApellidoMaterno, "+
                            "PER.FechaNacimiento "+
                            "FROM EMPLEADO AS EMP "+
                            "JOIN ESTADO AS EDO on EMP.ESTADOId = EDO.Id "+
                            "JOIN PUESTO AS PUES on EMP.PUESTOId = PUES.Id "+
                            "JOIN PERSONA AS PER ON EMP.PERSONAId = PER.Id " +
                            "WHERE EMP.ID = "+id;

            return contexto.Database.SqlQuery<clsEMPLEADO>(_query).FirstOrDefault();
        }


        public List<clsEMPLEADO> ListarEmpleados()
        {
            string _query = "SELECT " +
                            "EMP.Id AS EmpleadoId, " +
                            "EMP.Rfc, " +
                            "EMP.FechaIngreso, " +
                            "EDO.Nombre as Estado, EDO.Id as EstadoId, " +
                            "PUES.Nombre as Puesto, PUES.Id as PuestoId, " +
                            "PER.Id as PersonaId, PER.Nombres, PER.ApellidoPaterno, PER.ApellidoMaterno, " +
                            "PER.FechaNacimiento " +
                            "FROM EMPLEADO AS EMP " +
                            "JOIN ESTADO AS EDO on EMP.ESTADOId = EDO.Id " +
                            "JOIN PUESTO AS PUES on EMP.PUESTOId = PUES.Id " +
                            "JOIN PERSONA AS PER ON EMP.PERSONAId = PER.Id ";

            return contexto.Database.SqlQuery<clsEMPLEADO>(_query).ToList();
        }



    }
}
