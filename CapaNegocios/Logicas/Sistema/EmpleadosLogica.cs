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
        public List<ESTADO> LstEstado;
        public List<PUESTO> LstPuesto;
        public List<clsEMPLEADO> LstEmpleado;
        public List<clsEMPLEADO> LstEmpleadoAux;

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
            LstEstado = contextoEstado.Listar();  
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

        public void Activar(int id)
        {
            ObjEmpleado.ESTADOId = id; 
        }
        

        public bool Filtrar(int column, string termino)
        {
            if (LstEmpleadoAux == null) LstEmpleadoAux = LstEmpleado;

            switch (column)
            {
                case 1:
                    index = LstEmpleadoAux.FindIndex(x => x.Nombres.StartsWith(termino));
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
                    LstEmpleadoAux = LstEmpleado.OrderBy(x => x.Nombres).ToList();
                    break;

                default:
                    LstEmpleadoAux = LstEmpleado.OrderBy(x => x.Nombres).ToList();
                    break;

            }
        }




    }
}
