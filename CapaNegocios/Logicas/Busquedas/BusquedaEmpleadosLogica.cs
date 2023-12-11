using CapaDatos;
using CapaDatos.ADO.Sistema;
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Busquedas
{
    public class BusquedaEmpleadosLogica
    {
        private EmpleadosADO contexto;
        public List<clsBUSEMPLEADO> LstEmpleado;
        public List<clsBUSEMPLEADO> LstEmpleadoAux;
        public EMPLEADO ObjBUSEMPLEADO;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;

        public BusquedaEmpleadosLogica()
        {
            contexto = new EmpleadosADO();
        }

        public void ListarRegistros()
        {
            LstEmpleado = contexto.ListarEmpleados(); 
        }

        public clsEMPLEADO ObtenerRegistro(int id)
        {
            return contexto.ObtenerEmpleadoData(id);
        }

        public bool Filtrar(int column, string termino)
        {
            if (LstEmpleadoAux == null) LstEmpleadoAux = LstEmpleado;

            switch (column)
            {
                case 2:
                    index = LstEmpleadoAux.FindIndex(x => x.Nombre.StartsWith(termino));
                    break;
                case 3:
                    index = LstEmpleadoAux.FindIndex(x => x.Rfc.ToString().StartsWith(termino));
                    break;
                case 4:
                    index = LstEmpleadoAux.FindIndex(x => x.Estado.StartsWith(termino));
                    break;
                case 5:
                    index = LstEmpleadoAux.FindIndex(x => x.Puesto.StartsWith(termino));
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

                case 2:
                    LstEmpleadoAux = LstEmpleado.OrderBy(x => x.Nombre).ToList();
                    break;
                case 3:
                    LstEmpleadoAux = LstEmpleado.OrderBy(x => x.Rfc).ToList();
                    break;
                case 4:
                    LstEmpleadoAux = LstEmpleado.OrderBy(x => x.Estado).ToList();
                    break;
                case 5:
                    LstEmpleadoAux = LstEmpleado.OrderBy(x => x.Puesto).ToList();
                    break;

                default:
                    LstEmpleadoAux = LstEmpleado.OrderBy(x => x.Nombre).ToList();
                    break;

            }
        }




    }
}
