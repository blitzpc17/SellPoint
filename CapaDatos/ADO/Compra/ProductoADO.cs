using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADO.Compra
{
    public class ProductoADO
    {

        private DB_BOUTIQUEEntities contexto;

        public ProductoADO()
        {
            contexto = new DB_BOUTIQUEEntities();
        }

        public void Insertar(PRODUCTO entidad)
        {
            contexto.PRODUCTO.Add(entidad);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Eliminar(PRODUCTO entidad)
        {
            contexto.PRODUCTO.Remove(entidad);
        }

        public List<PRODUCTO> Listar()
        {
            return contexto.PRODUCTO.ToList();
        }

        public PRODUCTO Obtener(int id)
        {
            return contexto.PRODUCTO.FirstOrDefault(x => x.Id == id);
        }

        public List<clsPRODUCTO> ListarProductos()
        {
            string _query = "SELECT "+
                                "Productos.Id, Productos.CodigoBarras, Productos.Clave, Productos.Nombre, "+
                                "Productos.Marca, Productos.Proveedor, Productos.PrecioCompra as PrecioCompraBruto, Productos.PrecioVenta as PrecioVentaBruto,  "+
                                "Productos.MontoImpuestoCompra, MontoImpuestoVenta, (Productos.PrecioCompra + MontoImpuestoCompra) as PrecioFinalCompra,  "+
                                "(Productos.PrecioVenta + MontoImpuestoVenta) as PrecioFinalVenta, Productos.Impuesto, Productos.Estado "+
                                "FROM "+
                                "( "+
                                "SELECT "+
                                    " PRO.Id, "+
                                    " PRO.CodigoBarras, "+
                                    " PRO.Clave, "+
                                    " PRO.Nombre, "+
                                    " MAR.Nombre as Marca, "+
                                    " PROV.RazonSocial as Proveedor, "+
                                    " PRO.PrecioCompra, PRO.PrecioVenta, "+
                                    " SUM(PRO.PrecioCompra * IMP.Porcentaje) as MontoImpuestoCompra, "+
                                    " SUM(PRO.PrecioVenta * IMP.Porcentaje) as MontoImpuestoVenta, "+
                                    " CONVERT(BIT, "+
                                        "("+
                                            " SELECT CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END "+
                                            " FROM PRODUCTO_IMPUESTO AS PIM "+
                                            " JOIN IMPUESTO AS IMP ON PIM.Id = IMP.Id "+
                                            " WHERE PIM.PRODUCTOId = PRO.Id AND PIM.Baja = 0 "+
                                        ")"+
                                    ") as Impuesto, "+
	                                "EDO.Nombre as Estado "+
                                "FROM PRODUCTO AS PRO "+
                                "JOIN MARCA AS MAR ON PRO.MARCAId = MAR.Id "+
                                "JOIN PROVEEDOR AS PROV ON MAR.PROVEEDORId = PROV.Id "+
                                "JOIN ESTADO AS EDO ON PRO.ESTADOId = EDO.Id "+
                                "LEFT JOIN PRODUCTO_IMPUESTO AS PIM ON PRO.Id = PIM.PRODUCTOId "+
                                "LEFT JOIN IMPUESTO AS IMP ON PIM.Id = IMP.Id "+
                                "GROUP BY  PRO.Id,  "+
                                    " PRO.CodigoBarras, "+
                                    " PRO.Clave,  "+
                                    " PRO.Nombre,  "+
                                    " MAR.Nombre, "+
                                    " PROV.RazonSocial, "+
	                                " PRO.PrecioCompra, PRO.PrecioVenta, edo.Nombre "+
                                ") as Productos";

            return contexto.Database.SqlQuery<clsPRODUCTO>(_query).ToList();
        }

        public clsPRODUCTO ObtenerProducto(int id)
        {
            string _query = "SELECT " +
                            "PROV.Id, PROV.Clave,  PROV.RazonSocial, EDO.Nombre as Estado, EDO.Id as EstadoId " +
                            "FROM PROVEEDOR AS PROV " +
                            "JOIN ESTADO AS EDO ON PROV.ESTADOId = EDO.Id " +
                            "WHERE PROV.Id=" + id;

            return contexto.Database.SqlQuery<clsPRODUCTO>(_query).FirstOrDefault();
        }


    }
}
