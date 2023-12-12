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
    public class MarcaLogica
    {
        private MarcaADO contextoMarca;
        private EstadoADO contextoEstado;


        public MARCA ObjMarca;       
        public List<ESTADO> LstEstado;
        public List<clsMARCA> LstMarca;
        public List<clsMARCA> LstMarcaAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;


        public MarcaLogica()
        {
            contextoMarca = new MarcaADO();
            contextoEstado = new EstadoADO();
        }

        public void InstanciarMarca()
        {
            ObjMarca = new MARCA();
        }

        public void ListarMarca()
        {
            LstMarca = contextoMarca.ListarMarcas();
        }

        public void ListarCatalogos()
        {
            LstEstado = contextoEstado.Listar().Where(x => x.Proceso == "MARCA").ToList();
        }

        public void Guardar()
        {
            if (ObjMarca.Id == 0)
            {                
                contextoMarca.Insertar(ObjMarca);
            }

            contextoMarca.Guardar();
        }

        public MARCA ObtenerMarca(int id)
        {
            return contextoMarca.Obtener(id);
        }

        public bool Filtrar(int column, string termino)
        {
            if (LstMarcaAux == null) LstMarcaAux = LstMarca;

            switch (column)
            {
                case 1:
                    index = LstMarcaAux.FindIndex(x => x.Clave.StartsWith(termino));
                    break;
                case 2:
                    index = LstMarcaAux.FindIndex(x => x.Marca.ToString().StartsWith(termino));
                    break;
                case 3:
                    index = LstMarcaAux.FindIndex(x => x.Proveedor.ToString().StartsWith(termino));
                    break;
                case 4:
                    index = LstMarcaAux.FindIndex(x => x.Estado.StartsWith(termino));
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
                    LstMarcaAux = LstMarca.OrderBy(x => x.Clave).ThenBy(x=>x.Marca).ThenBy(x=>x.Proveedor).ThenBy(x => x.Estado).ToList();
                    break;
                case 2:
                    LstMarcaAux = LstMarca.OrderBy(x => x.Marca).ThenBy(x => x.Proveedor).ThenBy(x=>x.Estado).ThenBy(x => x.Clave).ToList();
                    break;
                case 3:
                    LstMarcaAux = LstMarca.OrderBy(x => x.Proveedor).ThenBy(x => x.Estado).ThenBy(x => x.Clave).ThenBy(x=>x.Marca).ToList();
                    break;
                case 4:
                    LstMarcaAux = LstMarca.OrderBy(x => x.Estado).ThenBy(x => x.Clave).ThenBy(x => x.Marca).ThenBy(x => x.Proveedor).ToList();
                    break;

                default:
                    LstMarcaAux = LstMarca.OrderBy(x => x.Clave).ThenBy(x => x.Marca).ThenBy(x => x.Proveedor).ThenBy(x => x.Estado).ToList();
                    break;

            }
        }



    }
}
