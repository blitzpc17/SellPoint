using CapaDatos;
using CapaDatos.ADO.Compra;
using CapaDatos.ADO.Sistema;
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Compras
{
    public class ProductosLogica
    {

        private ProductoADO contextoProducto;
        private EstadoADO contextoEstado;
        private ImpuestoADO contextoImpuesto;
        private MarcaADO contextoMarca;
        private ProductoImpuestoADO contextoProductoImpuesto;


        public PRODUCTO ObjProducto;
        public PRODUCTO_IMPUESTO ObjProductoImpuesto;
        public clsPRODUCTOIMPUESTO ObjProductoImpuestoAux;
        public List<ESTADO> LstEstado;
        public List<IMPUESTO> LstImpuesto;
        public List<clsPRODUCTOIMPUESTO> LstImpuestosProducto;
        public List<clsPRODUCTO> LstProducto;
        public List<clsPRODUCTO> LstProductoAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;


        public ProductosLogica()
        {
            contextoProducto = new ProductoADO();
            contextoEstado = new EstadoADO();
            contextoImpuesto = new ImpuestoADO();
            contextoMarca = new MarcaADO();
            contextoProductoImpuesto = new ProductoImpuestoADO();
        }

        public void InstanciarProducto()
        {
            ObjProducto = new PRODUCTO();
        }

        public void InstanciarImpuesto()
        {
            ObjProductoImpuesto = new PRODUCTO_IMPUESTO();
        }

        public void InstanciarProductoImpuesto()
        {
            ObjProductoImpuestoAux = new clsPRODUCTOIMPUESTO();
        }

        public void InstanciarListaImpuestos()
        {
            LstImpuestosProducto = new List<clsPRODUCTOIMPUESTO>();
        }

        public void ListarProductos()
        {
            LstProducto = contextoProducto.ListarProductos();
        }

        public void ListarCatalogos()
        {
            LstEstado = contextoEstado.Listar().Where(x => x.Proceso == "PRODUCTO").ToList();
            LstImpuesto = contextoImpuesto.Listar();
        }

        public PRODUCTO Obtener(int id)
        {
            return contextoProducto.Obtener(id);
        }

        public void Guardar()
        {
            if (ObjProducto.Id == 0)
            {
                contextoProducto.Insertar(ObjProducto);               
            }  
            contextoProducto.Guardar();

            if(LstImpuestosProducto!=null && LstImpuestosProducto.Count > 0)
            {
                foreach(var imp in LstImpuestosProducto)
                {
                    PRODUCTO_IMPUESTO obj;
                    obj = contextoProductoImpuesto.Obtener(imp.Id);
                    if (obj == null)
                    {
                        obj = new PRODUCTO_IMPUESTO();
                        obj.Baja = false;
                        obj.IMPUESTOId = imp.ImpuestoId; 
                        obj.PRODUCTOId = ObjProducto.Id;
                        contextoProductoImpuesto.Insertar(obj);
                    }
                    else
                    {
                        obj.Baja = imp.Baja;
                    }

                    contextoProductoImpuesto.Guardar();
                    
                }
            }
        }

        public clsPRODUCTO ObtenerProducto(int id)
        {
            return contextoProducto.ObtenerProducto(id);
        }

        public bool Filtrar(int column, string termino)
        {
            if (LstProductoAux == null) LstProductoAux = LstProducto;

            switch (column)
            {
                case 1:
                    index = LstProductoAux.FindIndex(x => x.Clave.StartsWith(termino));
                    break;
                case 2:
                    index = LstProductoAux.FindIndex(x => x.Nombre.ToString().StartsWith(termino));
                    break;
                case 3:
                    index = LstProductoAux.FindIndex(x => x.CodigoBarras.StartsWith(termino));
                    break;
                case 5:
                    index = LstProductoAux.FindIndex(x => x.Marca.StartsWith(termino));
                    break;
                case 6:
                    index = LstProductoAux.FindIndex(x => x.Proveedor.ToString().StartsWith(termino));
                    break;
                case 16:
                    index = LstProductoAux.FindIndex(x => x.Estado.ToString().StartsWith(termino));
                    break;

                default:
                    index = -1;
                    break;

            }

            return (index >= 0);

        }

        public void Ordenar(int column)
        {
            switch (column)
            {

                case 1:
                    LstProductoAux = LstProducto.OrderBy(x => x.Clave).ThenBy(x => x.Nombre).ThenBy(x=>x.CodigoBarras).ThenBy(x=>x.Proveedor).ThenBy(x=>x.Marca).ThenBy(x => x.Estado).ToList();
                    break;
                case 2:
                    LstProductoAux = LstProducto.OrderBy(x => x.Nombre).ThenBy(x => x.CodigoBarras).ThenBy(x => x.Proveedor).ThenBy(x => x.Marca).ThenBy(x => x.Estado).ThenBy(x => x.Clave).ToList();
                    break;
                case 3:
                    LstProductoAux = LstProducto.OrderBy(x => x.CodigoBarras).ThenBy(x => x.Proveedor).ThenBy(x => x.Marca).ThenBy(x => x.Estado).ThenBy(x => x.Clave).ThenBy(x => x.Nombre).ToList();
                    break;
                case 5:
                    LstProductoAux = LstProducto.OrderBy(x => x.Proveedor).ThenBy(x => x.Marca).ThenBy(x => x.Estado).ThenBy(x => x.Clave).ThenBy(x => x.Nombre).ThenBy(x => x.CodigoBarras).ToList();
                    break;
                case 6:
                    LstProductoAux = LstProducto.OrderBy(x => x.Marca).ThenBy(x => x.Estado).ThenBy(x => x.Clave).ThenBy(x => x.Nombre).ThenBy(x => x.CodigoBarras).ThenBy(x => x.Proveedor).ToList();
                    break;
                case 16:
                    LstProductoAux = LstProducto.OrderBy(x => x.Estado).ThenBy(x => x.Clave).ThenBy(x => x.Nombre).ThenBy(x => x.CodigoBarras).ThenBy(x => x.Proveedor).ThenBy(x => x.Marca).ToList();
                    break;

                default:
                    LstProductoAux = LstProducto.OrderBy(x => x.Clave).ThenBy(x => x.Nombre).ThenBy(x => x.CodigoBarras).ThenBy(x => x.Proveedor).ThenBy(x => x.Marca).ThenBy(x => x.Estado).ToList();
                    break;

            }
        }

        public void ListarImpuestosProducto(int ProductoId)
        {
            LstImpuestosProducto = contextoProductoImpuesto.ListarImpuestosProductos(ProductoId);
        }



    }
}
