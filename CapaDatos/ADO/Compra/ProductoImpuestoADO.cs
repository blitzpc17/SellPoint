using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Compra
{
    public class ProductoImpuestoADO
    {
        private DB_BOUTIQUEEntities contexto;

        public ProductoImpuestoADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(PRODUCTO_IMPUESTO entidad)
        {
            contexto.PRODUCTO_IMPUESTO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(PRODUCTO_IMPUESTO entidad)
        {
            contexto.PRODUCTO_IMPUESTO.Remove(entidad);
        }

        public List<PRODUCTO_IMPUESTO> Listar()
        {
            return contexto.PRODUCTO_IMPUESTO.ToList();
        }

        public PRODUCTO_IMPUESTO Obtener(int id)
        {
            return contexto.PRODUCTO_IMPUESTO.FirstOrDefault(x => x.Id == id);
        }

        public List<clsPRODUCTOIMPUESTO>ListarImpuestosProductos(int ProductoId)
        {
            var query = "SELECT "+
                        "PIM.Id, IMP.Nombre, IMP.Porcentaje, PIM.Baja, PRO.Id as ProductoId "+
                        "FROM PRODUCTO_IMPUESTO PIM "+
                        "JOIN PRODUCTO AS PRO ON PIM.PRODUCTOId = PRO.Id "+
                        "JOIN IMPUESTO AS IMP ON PIM.IMPUESTOId = IMP.Id " +
                        "WHERE PRO.Id = "+ProductoId;

            return contexto.Database.SqlQuery<clsPRODUCTOIMPUESTO>(query).ToList();
        }

       
    }
}
