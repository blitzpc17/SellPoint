using CapaDatos;
using CapaDatos.ADO.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Compras
{
    public class catImpuestosLogica
    {
        private ImpuestoADO contexto;
        public IMPUESTO ObjImpuesto;
        public List<IMPUESTO> LstImpuesto;
        public List<IMPUESTO> LstImpuestoAux;
        public int Index, Column, IndexAux;


        public catImpuestosLogica()
        {
            contexto = new ImpuestoADO();
        }
        public void InstanciarEstado()
        {
            ObjImpuesto = new IMPUESTO();
        }

        public void Guardar()
        {
            if (ObjImpuesto.Id == 0)
            {
                contexto.Insertar(ObjImpuesto);
            }

            contexto.Guardar();

        }

        public void Listar()
        {
            LstImpuesto = contexto.Listar();
        }

        public IMPUESTO Obtener(int id)
        {
            return contexto.Obtener(id);
        }

        public void Eliminar(IMPUESTO entidad)
        {
            contexto.Eliminar(entidad);
        }

        public bool Filtrar(int column, string termino)
        {
            if (LstImpuestoAux == null) LstImpuestoAux = LstImpuesto;

            switch (column)
            {
                case 1:
                    Index = LstImpuestoAux.FindIndex(x => x.Nombre.StartsWith(termino));
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
               
                default:
                    LstImpuestoAux = LstImpuesto.OrderBy(x => x.Nombre).ToList();
                    break;

            }
        }
    }
}
