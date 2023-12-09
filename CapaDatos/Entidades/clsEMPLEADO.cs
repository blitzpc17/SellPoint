using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class clsEMPLEADO
    {
        public int EmpleadoId { get; set; }
        public string Rfc { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Estado { get; set; }
        public int EstadoId { get; set; }
        public string Puesto { get; set; }
        public int PuestoId { get; set; }
        public int  PersonaId { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; } 
        public string ApellidoMaterno { get; set; } 
        public DateTime FechaNacimiento { get; set; }



    }
}
