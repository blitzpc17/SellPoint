using CapaDatos.ADO.Compra;
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Busquedas
{
    public class BusquedaProveedoresLogica
    {
        private ProveedorADO contexto;
        public List<clsPROVEEDOR> LstPROVEEDOR;
        public List<clsPROVEEDOR> LstPROVEEDORAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;

        public BusquedaProveedoresLogica()
        {
            contexto = new ProveedorADO();
        }

        public void ListarRegistros()
        {
            LstPROVEEDOR = contexto.ListarProveedores();
        }

        public clsPROVEEDOR ObtenerRegistro(int id)
        {
            return contexto.ObtenerProveedor(id);
        }

        public bool Filtrar(int column, string termino)
        {
            if (LstPROVEEDORAux == null) LstPROVEEDORAux = LstPROVEEDOR;

            switch (column)
            {
                case 1:
                    index = LstPROVEEDORAux.FindIndex(x => x.Clave.StartsWith(termino));
                    break;
                case 2:
                    index = LstPROVEEDORAux.FindIndex(x => x.RazonSocial.ToString().StartsWith(termino));
                    break;
                case 3:
                    index = LstPROVEEDORAux.FindIndex(x => x.Estado.ToString().StartsWith(termino));
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
                    LstPROVEEDORAux = LstPROVEEDOR.OrderBy(x => x.Clave).ThenBy(x => x.RazonSocial).ThenBy(x => x.Estado).ToList();
                    break;
                case 2:
                    LstPROVEEDORAux = LstPROVEEDOR.OrderBy(x => x.RazonSocial).ThenBy(x => x.Estado).ThenBy(x => x.Clave).ToList();
                    break;
                case 3:
                    LstPROVEEDORAux = LstPROVEEDOR.OrderBy(x => x.Estado).ThenBy(x => x.Clave).ThenBy(x => x.RazonSocial).ToList();
                    break;
               

                default:
                    LstPROVEEDORAux = LstPROVEEDOR.OrderBy(x => x.Clave).ThenBy(x => x.RazonSocial).ThenBy(x => x.Estado).ToList();
                    break;

            }
        }

    }
}
