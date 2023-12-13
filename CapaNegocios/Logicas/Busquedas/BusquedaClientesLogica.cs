using CapaDatos.ADO.Venta;
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Busquedas
{
    public class BusquedaClientesLogica
    {

        private ClienteADO contexto;
        public List<clsCLIENTE> LstCliente;
        public List<clsCLIENTE> LstClienteAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;

        public BusquedaClienteLogica()
        {
            contexto = new ClienteADO();
        }

        public void ListarRegistros()
        {
            LstCliente = contexto.ListarClientes();
        }

        public clsCLIENTE ObtenerRegistro(int id)
        {
            return contexto.ObtenerClienteData(id);
        }

        public bool Filtrar(int column, string termino)
        {
            if (LstClienteAux == null) LstClienteAux = LstCliente;

            switch (column)
            {
                case 1:
                    index = LstClienteAux.FindIndex(x => x.Clave.StartsWith(termino));
                    break;
                case 2:
                    index = LstClienteAux.FindIndex(x => x.Nombre.ToString().StartsWith(termino));
                    break;
                case 6:
                    index = LstClienteAux.FindIndex(x => x.Estado.StartsWith(termino));
                    break;
                case 7:
                    index = LstClienteAux.FindIndex(x => x.RFC.StartsWith(termino));
                    break;
                case 8:
                    index = LstClienteAux.FindIndex(x => x.RazonSocial.StartsWith(termino));
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
                    LstClienteAux = LstCliente.OrderBy(x => x.Clave).ThenBy(x => x.Nombres).ThenBy(x => x.Estado).ToList();
                    break;
                case 2:
                    LstClienteAux = LstCliente.OrderBy(x => x.Nombres).ThenBy(x => x.Clave).ThenBy(x => x.Nombres).ThenBy(x => x.Estado).ToList();
                    break;
                case 6:
                    LstClienteAux = LstCliente.OrderBy(x => x.Estado).ThenBy(x => x.Nombres).ThenBy(x => x.Clave).ThenBy(x => x.Nombres).ToList();
                    break;
                case 7:
                    LstClienteAux = LstCliente.OrderBy(x => x.RFC).ThenBy(x => x.Nombres).ThenBy(x => x.Clave).ThenBy(x => x.Nombres).ToList();
                    break;
                case 8:
                    LstClienteAux = LstCliente.OrderBy(x => x.RazonSocial).ThenBy(x => x.Nombres).ThenBy(x => x.Clave).ThenBy(x => x.Nombres).ToList();
                    break;

                default:
                    LstClienteAux = LstCliente.OrderBy(x => x.Clave).ThenBy(x => x.Nombres).ThenBy(x => x.Estado).ToList();
                    break;

            }
        }


    }
}
