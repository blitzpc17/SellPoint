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
    public class ProveedoresLogica
    {

        private ProveedorADO contextoProveedor;
        private PersonaADO contextoPersona;
        private EstadoADO contextoEstado;


        public PROVEEDOR ObjProveedor;
        public PERSONA ObjRepresentante;
        public List<ESTADO> LstEstado;
        public List<clsPROVEEDOR> LstProveedor;
        public List<clsPROVEEDOR> LstProveedorAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;


        public ProveedoresLogica()
        {
            contextoProveedor = new ProveedorADO();
            contextoEstado = new EstadoADO();
            contextoPersona = new PersonaADO();
        }

        public void InstanciarProveedor()
        {
            ObjProveedor = new PROVEEDOR();
            ObjRepresentante = new PERSONA();
        }

        public void ListarProveedores()
        {
            LstProveedor = contextoProveedor.ListarProveedores();
        }

        public void ListarCatalogos()
        {
            LstEstado = contextoEstado.Listar().Where(x => x.Proceso == "PROVEEDOR").ToList();
        }

        public void Guardar()
        {
            if (ObjProveedor.Id == 0)
            {
                contextoPersona.Insertar(ObjRepresentante);
                contextoPersona.Guardar();
                ObjProveedor.PERSONAIdRepresentante = ObjRepresentante.Id;
                contextoProveedor.Insertar(ObjProveedor);
            }
            else
            {
                contextoPersona.Guardar();
            }

            contextoProveedor.Guardar();
        }

        public PROVEEDOR ObtenerProveedor(int id)
        {
            return contextoProveedor.Obtener(id);
        }

        public bool Filtrar(int column, string termino)
        {
            if (LstProveedorAux == null) LstProveedorAux = LstProveedor;

            switch (column)
            {
                case 1:
                    index = LstProveedorAux.FindIndex(x => x.Clave.StartsWith(termino));
                    break;
                case 2:
                    index = LstProveedorAux.FindIndex(x => x.RazonSocial.ToString().StartsWith(termino));
                    break;
                case 3:
                    index = LstProveedorAux.FindIndex(x => x.Estado.StartsWith(termino));
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
                    LstProveedorAux = LstProveedor.OrderBy(x => x.Clave).ThenBy(x => x.RazonSocial).ThenBy(x => x.Estado).ToList();
                    break;
                case 2:
                    LstProveedorAux = LstProveedor.OrderBy(x => x.RazonSocial).ThenBy(x => x.Estado).ThenBy(x => x.Clave).ToList();
                    break;
                case 3:
                    LstProveedorAux = LstProveedor.OrderBy(x => x.Estado).ThenBy(x => x.Clave).ThenBy(x => x.RazonSocial).ToList();
                    break;

                default:
                    LstProveedorAux = LstProveedor.OrderBy(x => x.Clave).ThenBy(x => x.RazonSocial).ThenBy(x => x.Estado).ToList();
                    break;

            }
        }



    }
}
