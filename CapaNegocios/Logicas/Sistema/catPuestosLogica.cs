using CapaDatos;
using CapaDatos.ADO.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Sistema
{
    public class catPuestosLogica
    {
        private PuestosADO contextoPuesto;
        public PUESTO ObjPUESTO;
        public List<PUESTO> LstPUESTO;
        public List<PUESTO> LstPUESTOAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;

        public catPuestosLogica()
        {
            contextoPuesto= new PuestosADO();
        }

        public void InstanciarPUESTO()
        {
            ObjPUESTO = new PUESTO();
        }

        public void Guardar()
        {
            if (ObjPUESTO.Id == 0)
            {
                contextoPuesto.Insertar(ObjPUESTO);
            }

            contextoPuesto.Guardar();

        }

        public void Listar()
        {
            LstPUESTO = contextoPuesto.Listar();
        }

        public PUESTO Obtener(int id)
        {
            return contextoPuesto.Obtener(id);
        }

        public void Eliminar(PUESTO entidad)
        {
            contextoPuesto.Eliminar(entidad);
        }


        public bool Filtrar(int column, string termino)
        {
            if (LstPUESTOAux == null) LstPUESTOAux = LstPUESTO;

            switch (column)
            {
                case 1:
                    index = LstPUESTOAux.FindIndex(x => x.Nombre.StartsWith(termino));
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
                    LstPUESTOAux = LstPUESTO.OrderBy(x => x.Nombre).ToList();
                    break;

                default:
                    LstPUESTOAux = LstPUESTO.OrderBy(x => x.Nombre).ToList();
                    break;

            }
        }


    }
}
