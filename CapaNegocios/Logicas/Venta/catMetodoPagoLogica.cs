using CapaDatos;
using CapaDatos.ADO.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Venta
{
    public class catMetodoPagoLogica
    {
        private MetodoPagoADO contextoMETODOPAGO;
        public METODOPAGO ObjMETODOPAGO;
        public List<METODOPAGO> LstMETODOPAGO;
        public List<METODOPAGO> LstMETODOPAGOAux;

        public int Index = -1;
        public int IndexAux = -1;
        public int Column = 0;

        public catMetodoPagoLogica()
        {
            contextoMETODOPAGO = new MetodoPagoADO();
        }

        public void InstanciarMETODOPAGO()
        {
            ObjMETODOPAGO = new METODOPAGO();
        }

        public void Guardar()
        {
            if (ObjMETODOPAGO.Id == 0)
            {
                contextoMETODOPAGO.Insertar(ObjMETODOPAGO);
            }

            contextoMETODOPAGO.Guardar();

        }

        public void Listar()
        {
            LstMETODOPAGO = contextoMETODOPAGO.Listar();
        }

        public METODOPAGO Obtener(int id)
        {
            return contextoMETODOPAGO.Obtener(id);
        }

        public void Eliminar(METODOPAGO entidad)
        {
            contextoMETODOPAGO.Eliminar(entidad);
        }


        public bool Filtrar(int column, string termino)
        {
            if (LstMETODOPAGOAux == null) LstMETODOPAGOAux = LstMETODOPAGO;

            switch (column)
            {
                case 1:
                    Index = LstMETODOPAGOAux.FindIndex(x => x.Nombre.StartsWith(termino));
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
                    LstMETODOPAGOAux = LstMETODOPAGO.OrderBy(x => x.Nombre).ToList();
                    break;

                default:
                    LstMETODOPAGOAux = LstMETODOPAGO.OrderBy(x => x.Nombre).ToList();
                    break;

            }
        }


    }
}
