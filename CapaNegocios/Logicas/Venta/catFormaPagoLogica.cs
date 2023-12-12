using CapaDatos;
using CapaDatos.ADO.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Venta
{
    public class catFormaPagoLogica
    {
        private FormaPagoADO contextoFORMAPAGO;
        public FORMAPAGO ObjFORMAPAGO;
        public List<FORMAPAGO> LstFORMAPAGO;
        public List<FORMAPAGO> LstFORMAPAGOAux;

        public int Index = -1;
        public int IndexAux = -1;
        public int Column = 0;

        public catFormaPagoLogica()
        {
            contextoFORMAPAGO = new FormaPagoADO();
        }

        public void InstanciarFORMAPAGO()
        {
            ObjFORMAPAGO = new FORMAPAGO();
        }

        public void Guardar()
        {
            if (ObjFORMAPAGO.Id == 0)
            {
                contextoFORMAPAGO.Insertar(ObjFORMAPAGO);
            }

            contextoFORMAPAGO.Guardar();

        }

        public void Listar()
        {
            LstFORMAPAGO = contextoFORMAPAGO.Listar();
        }

        public FORMAPAGO Obtener(int id)
        {
            return contextoFORMAPAGO.Obtener(id);
        }

        public void Eliminar(FORMAPAGO entidad)
        {
            contextoFORMAPAGO.Eliminar(entidad);
        }


        public bool Filtrar(int column, string termino)
        {
            if (LstFORMAPAGOAux == null) LstFORMAPAGOAux = LstFORMAPAGO;

            switch (column)
            {
                case 1:
                    Index = LstFORMAPAGOAux.FindIndex(x => x.Nombre.StartsWith(termino));
                    break;

                default:
                    Index = -1;
                    break;

            }

            return (Index >= 0);

        }

        public void Ordenar(int column)
        {
            switch (column)
            {

                case 1:
                    LstFORMAPAGOAux = LstFORMAPAGO.OrderBy(x => x.Nombre).ToList();
                    break;

                default:
                    LstFORMAPAGOAux = LstFORMAPAGO.OrderBy(x => x.Nombre).ToList();
                    break;

            }
        }
    }
}
