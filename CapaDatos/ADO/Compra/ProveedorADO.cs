using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Compra
{
    public class ProveedorADO
    {
        private DB_BOUTIQUEEntities contexto;

        public ProveedorADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(PROVEEDOR entidad)
        {
            contexto.PROVEEDOR.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(PROVEEDOR entidad)
        {
            contexto.PROVEEDOR.Remove(entidad);
        }

        public List<PROVEEDOR> Listar()
        {
            return contexto.PROVEEDOR.ToList();
        }

        public PROVEEDOR Obtener(int id)
        {
            return contexto.PROVEEDOR.FirstOrDefault(x => x.Id == id);
        }

        public List<clsPROVEEDOR> ListarProveedores()
        {
            string _query = "SELECT " +
                            "PROV.Id, PROV.Clave,  PROV.RazonSocial, EDO.Nombre as Estado, EDO.Id as EstadoId " +
                            "FROM PROVEEDOR AS PROV " +                          
                            "JOIN ESTADO AS EDO ON PROV.ESTADOId = EDO.Id";

            return contexto.Database.SqlQuery<clsPROVEEDOR>(_query).ToList();
        }

        public clsPROVEEDOR ObtenerProveedor(int id)
        {
            string _query = "SELECT " +
                            "PROV.Id, PROV.Clave,  PROV.RazonSocial, EDO.Nombre as Estado, EDO.Id as EstadoId " +
                            "FROM PROVEEDOR AS PROV " +
                            "JOIN ESTADO AS EDO ON PROV.ESTADOId = EDO.Id " +
                            "WHERE PROV.Id="+id;

            return contexto.Database.SqlQuery<clsPROVEEDOR>(_query).FirstOrDefault();
        }


    }
}
