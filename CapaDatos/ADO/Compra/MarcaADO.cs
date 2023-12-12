using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Compra
{
    public class MarcaADO
    {

        private DB_BOUTIQUEEntities contexto;

        public MarcaADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(MARCA entidad)
        {
            contexto.MARCA.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(MARCA entidad)
        {
            contexto.MARCA.Remove(entidad);
        }

        public List<MARCA> Listar()
        {
            return contexto.MARCA.ToList();
        }

        public MARCA Obtener(int id)
        {
            return contexto.MARCA.FirstOrDefault(x => x.Id == id);
        }

        public clsMARCA ObtenerMarca(int id)
        {
            string _query = "SELECT " +
                            "MAR.Id, MAR.Clave,  PROV.RazonSocial as Proveedor,MAR.Nombre as Marca,  EDO.Nombre as Estado, EDO.Id as EstadoId " +
                            "FROM PROVEEDOR AS PROV " +
                            "JOIN MARCA AS MAR ON PROV.Id = MAR.PROVEEDORId " +
                            "JOIN ESTADO AS EDO ON MAR.ESTADOId = EDO.Id " +
                            "WHERE MAR.Id = "+id;

            return contexto.Database.SqlQuery<clsMARCA>(_query).FirstOrDefault();
        }

        public List<clsMARCA> ListarMarcas()
        {
            string _query = "SELECT " +
                            "MAR.Id, MAR.Clave,  PROV.RazonSocial as Proveedor,MAR.Nombre as Marca,  EDO.Nombre as Estado, EDO.Id as EstadoId " +
                            "FROM PROVEEDOR AS PROV " +
                            "JOIN MARCA AS MAR ON PROV.Id = MAR.PROVEEDORId "+
                            "JOIN ESTADO AS EDO ON MAR.ESTADOId = EDO.Id";

            return contexto.Database.SqlQuery<clsMARCA>(_query).ToList();
        }

    }
}
