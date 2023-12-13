using CapaDatos;
using CapaDatos.ADO.Sistema;
using CapaDatos.ADO.Venta;
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Venta
{
    public class formClientesLogica
    {
        private ClienteADO contextoCliente;
        private PersonaADO contextoPersona;
        private EstadoADO contextoEstado;


        public PERSONA ObjPersona;
        public CLIENTE ObjCliente;
        public clsCLIENTE ObjClsCliente;
        public List<ESTADO> LstEstado;
     
        public List<clsCLIENTE> LstCliente;
        public List<clsCLIENTE> LstClienteAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;


        public formClientesLogica()
        {
            contextoPersona = new PersonaADO();
            contextoEstado = new EstadoADO();
            contextoCliente = new ClienteADO();
        }

        public void InstanciarCliente()
        {
            ObjPersona = new PERSONA();
            ObjCliente = new CLIENTE();
        }

        public void ListarCatalogos()
        {
            LstEstado = contextoEstado.Listar().Where(x=>x.Proceso=="CLIENTE").ToList();
        }

        public void Guardar()
        {
            if (ObjCliente.Id == 0)
            {
                contextoPersona.Insertar(ObjPersona);
                contextoPersona.Guardar();
                ObjCliente.PERSONAId = ObjPersona.Id;   
                contextoCliente.Insertar(ObjCliente);
            }
            else
            {
                contextoPersona.Guardar();
            }            
            contextoCliente.Guardar();
        }

        public void Listar()
        {
            LstCliente = contextoCliente.ListarClientes();  
        }

        public clsCLIENTE ObtenerClienteData(int id)
        {
            return contextoCliente.ObtenerClienteData(id);
        }

        public CLIENTE ObtenerCliente(int id)
        {
            return contextoCliente.Obtener(id);
        }

        public PERSONA ObtenerPersona(int id)
        {
            return contextoPersona.Obtener(id);
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
                    LstClienteAux = LstCliente.OrderBy(x => x.Clave).ThenBy(x=>x.Nombres).ThenBy(x=>x.Estado).ToList();
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
