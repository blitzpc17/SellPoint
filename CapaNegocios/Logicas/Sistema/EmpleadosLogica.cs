using CapaDatos;
using CapaDatos.ADO.Sistema;
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Sistema
{
    public class EmpleadosLogica
    {
        private PersonaADO contextoPersona;
        private EmpleadosADO contextoEmpleados;
        private EstadoADO contextoEstado;
        private PuestosADO contextoPuesto;


        public PERSONA ObjPersona;
        public EMPLEADO ObjEmpleado;
        public clsEMPLEADO ObjClsEmpleado;
        public List<ESTADO> LstEstado;
        public List<PUESTO> LstPuesto;
        public List<clsBUSEMPLEADO> LstEmpleado;
        public List<clsBUSEMPLEADO> LstEmpleadoAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;    
        

        public EmpleadosLogica()
        {
            contextoEmpleados = new EmpleadosADO(); 
            contextoEstado = new EstadoADO();
            contextoPersona = new PersonaADO(); 
            contextoPuesto = new PuestosADO();  
        }

        public void InstanciarEmpleado()
        {
            ObjPersona = new PERSONA();
            ObjEmpleado = new EMPLEADO();
        }

        public void ListarCatalogos()
        {
            LstPuesto = contextoPuesto.Listar();
            LstEstado = contextoEstado.Listar().Where(x=>x.Proceso=="EMPLEADO").ToList();  
        }

        public void Guardar()
        {
            if (ObjEmpleado.Id == 0)
            {
                contextoPersona.Insertar(ObjPersona);
            }
            
            contextoPersona.Guardar();

            if (ObjEmpleado.Id == 0)
            {
                ObjEmpleado.PERSONAId = ObjPersona.Id;
                contextoEmpleados.Insertar(ObjEmpleado);
            }
                   
            contextoEmpleados.Guardar();
        }

        public void Listar()
        {
            LstEmpleado = contextoEmpleados.ListarEmpleados();
        }

        public clsEMPLEADO ObtenerEmpleadoData(int id)
        {
            return contextoEmpleados.ObtenerEmpleadoData(id);
        }


        public void ObtenerPersonaEmpleadoData(int id)
        {
            ObjEmpleado = contextoEmpleados.Obtener(id);
            ObjPersona = contextoPersona.Obtener(ObjEmpleado.PERSONAId);
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
